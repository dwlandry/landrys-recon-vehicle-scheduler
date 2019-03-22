//-----------------------------------------------------------------------
// <copyright file="C:\Users\dlandry\source\repos\landrys-recon-vehicle-scheduler\landrys-recon-vehicle-scheduler\MyRibbon.cs" company="David W. Landry III">
//     Author: _**David Landry**_
//     *Copyright (c) David W. Landry III. All rights reserved.*
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Linq;

namespace landrys_recon_vehicle_scheduler
{
    public partial class MyRibbon
    {
        private void MyRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void buttonReserveVehicle_Click(object sender, RibbonControlEventArgs e)
        {
            AddVehicleForm vehicleForm = new AddVehicleForm();
            vehicleForm.Show();
        }
    }
}
