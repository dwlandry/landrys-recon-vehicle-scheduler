//-----------------------------------------------------------------------
// <copyright file="C:\Users\dlandry\source\repos\landrys-recon-vehicle-scheduler\landrys-recon-vehicle-scheduler\MyRibbon.Designer.cs" company="David W. Landry III">
//     Author: _**David Landry**_
//     *Copyright (c) David W. Landry III. All rights reserved.*
// </copyright>
//-----------------------------------------------------------------------
namespace landrys_recon_vehicle_scheduler
{
    partial class MyRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MyRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reConTab = this.Factory.CreateRibbonTab();
            this.groupVehicles = this.Factory.CreateRibbonGroup();
            this.buttonUpdateVehicleResources = this.Factory.CreateRibbonButton();
            this.buttonReserveVehicle = this.Factory.CreateRibbonButton();
            this.reConTab.SuspendLayout();
            this.groupVehicles.SuspendLayout();
            this.SuspendLayout();
            // 
            // reConTab
            // 
            this.reConTab.Groups.Add(this.groupVehicles);
            this.reConTab.Label = "ReCon";
            this.reConTab.Name = "reConTab";
            // 
            // groupVehicles
            // 
            this.groupVehicles.Items.Add(this.buttonUpdateVehicleResources);
            this.groupVehicles.Items.Add(this.buttonReserveVehicle);
            this.groupVehicles.Label = "Vehicles";
            this.groupVehicles.Name = "groupVehicles";
            // 
            // buttonUpdateVehicleResources
            // 
            this.buttonUpdateVehicleResources.Label = "Update Vehicle Resources";
            this.buttonUpdateVehicleResources.Name = "buttonUpdateVehicleResources";
            // 
            // buttonReserveVehicle
            // 
            this.buttonReserveVehicle.Label = "Reserve A Vehicle";
            this.buttonReserveVehicle.Name = "buttonReserveVehicle";
            // 
            // MyRibbon
            // 
            this.Name = "MyRibbon";
            this.RibbonType = "Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.reConTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MyRibbon_Load);
            this.reConTab.ResumeLayout(false);
            this.reConTab.PerformLayout();
            this.groupVehicles.ResumeLayout(false);
            this.groupVehicles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab reConTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupVehicles;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonUpdateVehicleResources;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonReserveVehicle;
    }

    partial class ThisRibbonCollection
    {
        internal MyRibbon MyRibbon
        {
            get { return this.GetRibbon<MyRibbon>(); }
        }
    }
}
