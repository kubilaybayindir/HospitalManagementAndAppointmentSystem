﻿namespace HospitalManagementAndAppointmentSystem
{
    partial class FormAppointmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppointmentList));
            this.DgvAppointmentList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAppointmentList
            // 
            this.DgvAppointmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAppointmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAppointmentList.Location = new System.Drawing.Point(0, 0);
            this.DgvAppointmentList.Name = "DgvAppointmentList";
            this.DgvAppointmentList.ReadOnly = true;
            this.DgvAppointmentList.Size = new System.Drawing.Size(800, 450);
            this.DgvAppointmentList.TabIndex = 0; 
            // 
            // FormAppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvAppointmentList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAppointmentList";
            this.Text = "Appointment List";
            this.Load += new System.EventHandler(this.FormAppointmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAppointmentList;
    }
}