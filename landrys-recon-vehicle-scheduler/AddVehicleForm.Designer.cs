//-----------------------------------------------------------------------
// <copyright file="C:\Users\dlandry\source\repos\landrys-recon-vehicle-scheduler\landrys-recon-vehicle-scheduler\AddVehicleForm.Designer.cs" company="David W. Landry III">
//     Author: _**David Landry**_
//     *Copyright (c) David W. Landry III. All rights reserved.*
// </copyright>
//-----------------------------------------------------------------------
namespace landrys_recon_vehicle_scheduler
{
    partial class AddVehicleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateReturned = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWhere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWho = new System.Windows.Forms.TextBox();
            this.buttonMakeReservation = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelScheduleConflict = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonSulfur = new System.Windows.Forms.RadioButton();
            this.radioButtonTexas = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxControlVehicles = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDateOut
            // 
            this.dateTimePickerDateOut.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePickerDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOut.Location = new System.Drawing.Point(225, 90);
            this.dateTimePickerDateOut.Name = "dateTimePickerDateOut";
            this.dateTimePickerDateOut.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerDateOut.TabIndex = 1;
            this.dateTimePickerDateOut.ValueChanged += new System.EventHandler(this.dateTimePickerDateOut_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time Out";
            // 
            // dateTimePickerDateReturned
            // 
            this.dateTimePickerDateReturned.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePickerDateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateReturned.Location = new System.Drawing.Point(225, 148);
            this.dateTimePickerDateReturned.Name = "dateTimePickerDateReturned";
            this.dateTimePickerDateReturned.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerDateReturned.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Approx Time to be Returned";
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.Location = new System.Drawing.Point(225, 206);
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(272, 20);
            this.textBoxWhere.TabIndex = 5;
            this.textBoxWhere.TextChanged += new System.EventHandler(this.textBoxWhere_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Where are you going?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Who will be with you?";
            // 
            // textBoxWho
            // 
            this.textBoxWho.Location = new System.Drawing.Point(225, 263);
            this.textBoxWho.Name = "textBoxWho";
            this.textBoxWho.Size = new System.Drawing.Size(272, 20);
            this.textBoxWho.TabIndex = 6;
            // 
            // buttonMakeReservation
            // 
            this.buttonMakeReservation.Location = new System.Drawing.Point(225, 299);
            this.buttonMakeReservation.Name = "buttonMakeReservation";
            this.buttonMakeReservation.Size = new System.Drawing.Size(137, 23);
            this.buttonMakeReservation.TabIndex = 7;
            this.buttonMakeReservation.Text = "Make Reservation";
            this.buttonMakeReservation.UseVisualStyleBackColor = true;
            this.buttonMakeReservation.Click += new System.EventHandler(this.buttonMakeReservation_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(422, 299);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelScheduleConflict
            // 
            this.labelScheduleConflict.AutoSize = true;
            this.labelScheduleConflict.BackColor = System.Drawing.Color.Red;
            this.labelScheduleConflict.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduleConflict.ForeColor = System.Drawing.Color.White;
            this.labelScheduleConflict.Location = new System.Drawing.Point(15, 338);
            this.labelScheduleConflict.Name = "labelScheduleConflict";
            this.labelScheduleConflict.Size = new System.Drawing.Size(441, 13);
            this.labelScheduleConflict.TabIndex = 10;
            this.labelScheduleConflict.Text = "This vehicle is already reserved during this time window.  See outlook calendar f" +
    "or more info.";
            this.labelScheduleConflict.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // radioButtonSulfur
            // 
            this.radioButtonSulfur.AutoSize = true;
            this.radioButtonSulfur.Image = global::landrys_recon_vehicle_scheduler.Properties.Resources.Louisiana;
            this.radioButtonSulfur.Location = new System.Drawing.Point(119, 29);
            this.radioButtonSulfur.Name = "radioButtonSulfur";
            this.radioButtonSulfur.Size = new System.Drawing.Size(74, 51);
            this.radioButtonSulfur.TabIndex = 12;
            this.radioButtonSulfur.UseVisualStyleBackColor = true;
            this.radioButtonSulfur.CheckedChanged += new System.EventHandler(this.radioButtonSulfur_CheckedChanged);
            // 
            // radioButtonTexas
            // 
            this.radioButtonTexas.AutoSize = true;
            this.radioButtonTexas.Image = global::landrys_recon_vehicle_scheduler.Properties.Resources.Texas;
            this.radioButtonTexas.Location = new System.Drawing.Point(12, 28);
            this.radioButtonTexas.Name = "radioButtonTexas";
            this.radioButtonTexas.Size = new System.Drawing.Size(74, 58);
            this.radioButtonTexas.TabIndex = 12;
            this.radioButtonTexas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButtonTexas.UseVisualStyleBackColor = true;
            this.radioButtonTexas.CheckedChanged += new System.EventHandler(this.radioButtonTexas_CheckedChanged);
            // 
            // listBoxControlVehicles
            // 
            this.listBoxControlVehicles.FormattingEnabled = true;
            this.listBoxControlVehicles.Location = new System.Drawing.Point(18, 92);
            this.listBoxControlVehicles.Name = "listBoxControlVehicles";
            this.listBoxControlVehicles.Size = new System.Drawing.Size(198, 238);
            this.listBoxControlVehicles.TabIndex = 13;
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(509, 363);
            this.Controls.Add(this.listBoxControlVehicles);
            this.Controls.Add(this.radioButtonSulfur);
            this.Controls.Add(this.radioButtonTexas);
            this.Controls.Add(this.labelScheduleConflict);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonMakeReservation);
            this.Controls.Add(this.textBoxWho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWhere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDateReturned);
            this.Controls.Add(this.dateTimePickerDateOut);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reserve Company Vehicle";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateReturned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWhere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWho;
        private System.Windows.Forms.Button buttonMakeReservation;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelScheduleConflict;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonTexas;
        private System.Windows.Forms.RadioButton radioButtonSulfur;
        private System.Windows.Forms.ListBox listBoxControlVehicles;
    }
}