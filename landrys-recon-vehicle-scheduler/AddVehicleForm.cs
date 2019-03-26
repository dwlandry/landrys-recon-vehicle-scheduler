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

            if (listBoxControlVehicles.SelectedValue == null || listBoxControlVehicles.ItemCount == 0) return;
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

    }
}
