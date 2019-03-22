//-----------------------------------------------------------------------
// <copyright file="C:\Users\dlandry\source\repos\landrys-recon-vehicle-scheduler\landrys-recon-vehicle-scheduler\Vehicle.cs" company="David W. Landry III">
//     Author: _**David Landry**_
//     *Copyright (c) David W. Landry III. All rights reserved.*
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace landrys_recon_vehicle_scheduler
{
    public class Vehicle
    {
        public Vehicle(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
