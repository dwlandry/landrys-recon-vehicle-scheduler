//-----------------------------------------------------------------------
// <copyright file="C:\Users\dlandry\source\repos\landrys-recon-vehicle-scheduler\landrys-recon-vehicle-scheduler\AddVehicleForm.cs" company="David W. Landry III">
//     Author: _**David Landry**_
//     *Copyright (c) David W. Landry III. All rights reserved.*
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace landrys_recon_vehicle_scheduler
{
    public partial class AddVehicleForm : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        Microsoft.Office.Interop.Outlook.AddressLists addressLists;
        Microsoft.Office.Interop.Outlook.AddressList globalAddressList;

        public AddVehicleForm()
        {
            InitializeComponent();
            listBoxControlVehicles.SelectedValueChanged += schedulingDataChanged;
            dateTimePickerDateOut.ValueChanged += schedulingDataChanged;
            dateTimePickerDateReturned.ValueChanged += schedulingDataChanged;

            bindingSource1.DataSource = vehicles;
            listBoxControlVehicles.DataSource = bindingSource1.DataSource;
            listBoxControlVehicles.DisplayMember = "Name";
            listBoxControlVehicles.ValueMember = "Name";

            dateTimePickerDateReturned.Value = dateTimePickerDateOut.Value.AddHours(1);

        }

        private void buttonMakeReservation_Click(object sender, EventArgs e)
        {
            #region Validate Data
            // Validate Data

            if (listBoxControlVehicles.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle.");
                listBoxControlVehicles.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textBoxWhere.Text))
            {
                MessageBox.Show("'Where are you going?' cannot be empty.");
                textBoxWhere.Focus();
                return;
            }

            TimeSpan span = dateTimePickerDateReturned.Value - dateTimePickerDateOut.Value;
            int totalMinutes = (int)Math.Round(span.TotalMinutes, 0);
            if (totalMinutes <= 0)
            {
                MessageBox.Show("Return Time must be later than Time Out.");
                dateTimePickerDateOut.Focus();
                return;
            }

            #endregion

            Microsoft.Office.Interop.Outlook.AppointmentItem vehicleReservationMeeting = (Microsoft.Office.Interop.Outlook.AppointmentItem)
                Globals.ThisAddIn.Application.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olAppointmentItem);

            if (vehicleReservationMeeting != null)
            {
                vehicleReservationMeeting.MeetingStatus = Microsoft.Office.Interop.Outlook.OlMeetingStatus.olMeeting;
                vehicleReservationMeeting.Body = string.IsNullOrEmpty(textBoxWho.Text) ? textBoxWhere.Text : string.Format("{0} (With {1})", textBoxWhere.Text, textBoxWho.Text);
                vehicleReservationMeeting.Start = dateTimePickerDateOut.Value;
                vehicleReservationMeeting.Duration = totalMinutes;
                vehicleReservationMeeting.Subject = "Vehicle Checkout";
                vehicleReservationMeeting.ReminderSet = false;
                var vehicle = listBoxControlVehicles.SelectedValue.ToString();
                Microsoft.Office.Interop.Outlook.Recipient recipient = vehicleReservationMeeting.Recipients.Add(vehicle);
                recipient.Type = (int)Microsoft.Office.Interop.Outlook.OlMeetingRecipientType.olResource;
                vehicleReservationMeeting.Recipients.ResolveAll();
                vehicleReservationMeeting.Send();
                Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePickerDateOut_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDateReturned.Value = dateTimePickerDateOut.Value.AddHours(1);
        }

        void schedulingDataChanged(object sender, EventArgs a)
        {
            TimeSpan span = dateTimePickerDateReturned.Value - dateTimePickerDateOut.Value;
            int totalMinutes = (int)Math.Round(span.TotalMinutes, 0);

            if (listBoxControlVehicles.SelectedValue == null || listBoxControlVehicles.Items.Count == 0) return;
            var vehicleName = ((Vehicle)listBoxControlVehicles.SelectedItem).Name;

            Microsoft.Office.Interop.Outlook.AppointmentItem vehicleReservationMeeting = (Microsoft.Office.Interop.Outlook.AppointmentItem)
                Globals.ThisAddIn.Application.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olAppointmentItem);

            Microsoft.Office.Interop.Outlook.Recipient recipient = vehicleReservationMeeting.Recipients.Add(vehicleName);
            recipient.Type = (int)Microsoft.Office.Interop.Outlook.OlMeetingRecipientType.olResource;

            var freeBusyInfo = recipient.FreeBusy(dateTimePickerDateOut.Value, 1);
            var startminute = new TimeSpan(dateTimePickerDateOut.Value.Hour, dateTimePickerDateOut.Value.Minute, 0).TotalMinutes;
            labelScheduleConflict.Visible = freeBusyInfo.Substring((int)startminute, totalMinutes).Contains("1");

        }

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            //AboutBox1 aboutBox = new AboutBox1();
            //aboutBox.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void radioButtonTexas_CheckedChanged(object sender, EventArgs e) { if (radioButtonTexas.Checked) UpdateVehiclesList("T-"); }

        private void radioButtonSulfur_CheckedChanged(object sender, EventArgs e) { if (radioButtonSulfur.Checked) UpdateVehiclesList("S-"); }

        private void UpdateVehiclesList(string startsWith)
        {
            // initialize vehicle list

            vehicles.Clear();

            try
            {
                addressLists = Globals.ThisAddIn.Application.Session.AddressLists;
                globalAddressList = addressLists["Global Address List"];
                foreach (Microsoft.Office.Interop.Outlook.AddressEntry addressEntry in globalAddressList.AddressEntries)
                    if (addressEntry.Name.StartsWith(startsWith))
                        vehicles.Add(new Vehicle(addressEntry.Name));
                listBoxControlVehicles.Refresh();
            }
            catch (Exception)
            {
                return;
                //throw;
            }
            
        }

        private void textBoxWhere_TextChanged(object sender, EventArgs e)
        {
            radioButtonSulfur.Image = textBoxWhere.Text.ToLower().Equals("sulphur") ? Properties.Resources.PoopEmoji : Properties.Resources.Louisiana;
        }

        //private void toolStripMenuItemCheckForUpdate_Click(object sender, EventArgs e)
        //{
        //    InstallUpdateSyncWithInfo();
        //}

        //// 3-25-2019: DLandry: This solution is copied from here: https://docs.microsoft.com/en-us/visualstudio/deployment/how-to-check-for-application-updates-programmatically-using-the-clickonce-deployment-api?view=vs-2017
        //private void InstallUpdateSyncWithInfo()
        //{
        //    UpdateCheckInfo info = null;

        //    if (ApplicationDeployment.IsNetworkDeployed)
        //    {
        //        ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

        //        try
        //        {
        //            info = ad.CheckForDetailedUpdate();

        //        }
        //        catch (DeploymentDownloadException dde)
        //        {
        //            MessageBox.Show("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later. Error: " + dde.Message);
        //            return;
        //        }
        //        catch (InvalidDeploymentException ide)
        //        {
        //            MessageBox.Show("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
        //            return;
        //        }
        //        catch (InvalidOperationException ioe)
        //        {
        //            MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
        //            return;
        //        }

        //        if (info.UpdateAvailable)
        //        {
        //            Boolean doUpdate = true;

        //            if (!info.IsUpdateRequired)
        //            {
        //                DialogResult dr = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel);
        //                if (!(DialogResult.OK == dr))
        //                {
        //                    doUpdate = false;
        //                }
        //            }
        //            else
        //            {
        //                // Display a message that the app MUST reboot. Display the minimum required version.
        //                MessageBox.Show("This application has detected a mandatory update from your current " +
        //                    "version to version " + info.MinimumRequiredVersion.ToString() +
        //                    ". The application will now install the update and restart.",
        //                    "Update Available", MessageBoxButtons.OK,
        //                    MessageBoxIcon.Information);
        //            }

        //            if (doUpdate)
        //            {
        //                try
        //                {
        //                    ad.Update();
        //                    MessageBox.Show("The application has been upgraded, and will now restart.");
        //                    Application.Restart();
        //                }
        //                catch (DeploymentDownloadException dde)
        //                {
        //                    MessageBox.Show("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later. Error: " + dde);
        //                    return;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
