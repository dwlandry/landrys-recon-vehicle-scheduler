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
            this.listBoxControlVehicles = new DevExpress.XtraEditors.ListBoxControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateReturned = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWhere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWho = new System.Windows.Forms.TextBox();
            this.buttonMakeReservation = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelScheduleConflict = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControlVehicles
            // 
            this.listBoxControlVehicles.Location = new System.Drawing.Point(12, 33);
            this.listBoxControlVehicles.Name = "listBoxControlVehicles";
            this.listBoxControlVehicles.Size = new System.Drawing.Size(181, 193);
            this.listBoxControlVehicles.TabIndex = 0;
            // 
            // dateTimePickerDateOut
            // 
            this.dateTimePickerDateOut.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePickerDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOut.Location = new System.Drawing.Point(225, 33);
            this.dateTimePickerDateOut.Name = "dateTimePickerDateOut";
            this.dateTimePickerDateOut.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerDateOut.TabIndex = 1;
            this.dateTimePickerDateOut.ValueChanged += new System.EventHandler(this.dateTimePickerDateOut_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time Out";
            // 
            // dateTimePickerDateReturned
            // 
            this.dateTimePickerDateReturned.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePickerDateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateReturned.Location = new System.Drawing.Point(225, 91);
            this.dateTimePickerDateReturned.Name = "dateTimePickerDateReturned";
            this.dateTimePickerDateReturned.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerDateReturned.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Approx Time to be Returned";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Vehicle";
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.Location = new System.Drawing.Point(225, 149);
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(272, 20);
            this.textBoxWhere.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Where are you going?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Who will be with you?";
            // 
            // textBoxWho
            // 
            this.textBoxWho.Location = new System.Drawing.Point(225, 206);
            this.textBoxWho.Name = "textBoxWho";
            this.textBoxWho.Size = new System.Drawing.Size(272, 20);
            this.textBoxWho.TabIndex = 6;
            // 
            // buttonMakeReservation
            // 
            this.buttonMakeReservation.Location = new System.Drawing.Point(225, 242);
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
            this.buttonCancel.Location = new System.Drawing.Point(422, 242);
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
            this.labelScheduleConflict.Location = new System.Drawing.Point(15, 281);
            this.labelScheduleConflict.Name = "labelScheduleConflict";
            this.labelScheduleConflict.Size = new System.Drawing.Size(441, 13);
            this.labelScheduleConflict.TabIndex = 10;
            this.labelScheduleConflict.Text = "This vehicle is already reserved during this time window.  See outlook calendar f" +
    "or more info.";
            this.labelScheduleConflict.Visible = false;
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(509, 306);
            this.Controls.Add(this.labelScheduleConflict);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonMakeReservation);
            this.Controls.Add(this.textBoxWho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWhere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDateReturned);
            this.Controls.Add(this.dateTimePickerDateOut);
            this.Controls.Add(this.listBoxControlVehicles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVehicleForm";
            this.Text = "Reserve Company Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControlVehicles;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateReturned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWhere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWho;
        private System.Windows.Forms.Button buttonMakeReservation;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelScheduleConflict;
    }
}