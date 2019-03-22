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
        public AddVehicleForm()
        {
            InitializeComponent();
            this.listBoxControlVehicles.SelectedValueChanged += schedulingDataChanged;
            this.dateTimePickerDateOut.ValueChanged += schedulingDataChanged;
            this.dateTimePickerDateReturned.ValueChanged += schedulingDataChanged;



            dateTimePickerDateReturned.Value = dateTimePickerDateOut.Value.AddHours(1);

            // initialize vehicle list
            List<Vehicle> vehicles = new List<Vehicle>();

            var addressLists = Globals.ThisAddIn.Application.Session.AddressLists;
            var globalAddressList = addressLists["Global Address List"];

            foreach (Microsoft.Office.Interop.Outlook.AddressEntry addressEntry in globalAddressList.AddressEntries)
                if (addressEntry.Name.StartsWith("T-"))
                    vehicles.Add(new Vehicle(addressEntry.Name));

            bindingSource1.DataSource = vehicles;
            listBoxControlVehicles.DataSource = bindingSource1.DataSource;
            listBoxControlVehicles.DisplayMember = "Name";
            listBoxControlVehicles.ValueMember = "Name";
        }

        private void buttonMakeReservation_Click(object sender, EventArgs e)
        {
            #region Validate Data
            // Validate Data

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
                var vehicleName = ((Vehicle)listBoxControlVehicles.SelectedItem).Name;
                Microsoft.Office.Interop.Outlook.Recipient recipient = vehicleReservationMeeting.Recipients.Add(vehicleName);
                recipient.Type = (int)Microsoft.Office.Interop.Outlook.OlMeetingRecipientType.olResource;
                vehicleReservationMeeting.Recipients.ResolveAll();
                vehicleReservationMeeting.Display(false);
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
    }
}
