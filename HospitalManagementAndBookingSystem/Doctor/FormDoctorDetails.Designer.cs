namespace HospitalManagementAndAppointmentSystem.Doctor
{
    partial class FormDoctorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctorDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.LblDoctorIdentityNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvAppointmentHistory = new System.Windows.Forms.DataGridView();
            this.RTbxDisease = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.BtAnnouncements = new System.Windows.Forms.Button();
            this.BtDoctorEditDetails = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointmentHistory)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.LblDoctorIdentityNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Details";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNameSurname.Location = new System.Drawing.Point(165, 90);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(81, 24);
            this.LblNameSurname.TabIndex = 3;
            this.LblNameSurname.Text = "Null Null";
            // 
            // LblDoctorIdentityNumber
            // 
            this.LblDoctorIdentityNumber.AutoSize = true;
            this.LblDoctorIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDoctorIdentityNumber.Location = new System.Drawing.Point(165, 51);
            this.LblDoctorIdentityNumber.Name = "LblDoctorIdentityNumber";
            this.LblDoctorIdentityNumber.Size = new System.Drawing.Size(120, 24);
            this.LblDoctorIdentityNumber.TabIndex = 2;
            this.LblDoctorIdentityNumber.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name-Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identity Number:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvAppointmentHistory);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(305, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 439);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment List";
            // 
            // DgvAppointmentHistory
            // 
            this.DgvAppointmentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAppointmentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAppointmentHistory.Location = new System.Drawing.Point(3, 25);
            this.DgvAppointmentHistory.Name = "DgvAppointmentHistory";
            this.DgvAppointmentHistory.Size = new System.Drawing.Size(484, 411);
            this.DgvAppointmentHistory.TabIndex = 0;
            this.DgvAppointmentHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAppointmentHistory_CellClick);
            // 
            // RTbxDisease
            // 
            this.RTbxDisease.Location = new System.Drawing.Point(12, 28);
            this.RTbxDisease.Name = "RTbxDisease";
            this.RTbxDisease.Size = new System.Drawing.Size(273, 167);
            this.RTbxDisease.TabIndex = 6;
            this.RTbxDisease.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RTbxDisease);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(5, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 207);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Details";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.BtAnnouncements);
            this.groupBox4.Controls.Add(this.BtDoctorEditDetails);
            this.groupBox4.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(5, 339);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shortcut Access";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(12, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BtAnnouncements
            // 
            this.BtAnnouncements.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtAnnouncements.Location = new System.Drawing.Point(148, 24);
            this.BtAnnouncements.Name = "BtAnnouncements";
            this.BtAnnouncements.Size = new System.Drawing.Size(137, 32);
            this.BtAnnouncements.TabIndex = 1;
            this.BtAnnouncements.Text = "Announcements";
            this.BtAnnouncements.UseVisualStyleBackColor = true;
            this.BtAnnouncements.Click += new System.EventHandler(this.BtAnnouncements_Click);
            // 
            // BtDoctorEditDetails
            // 
            this.BtDoctorEditDetails.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDoctorEditDetails.Location = new System.Drawing.Point(11, 24);
            this.BtDoctorEditDetails.Name = "BtDoctorEditDetails";
            this.BtDoctorEditDetails.Size = new System.Drawing.Size(127, 32);
            this.BtDoctorEditDetails.TabIndex = 0;
            this.BtDoctorEditDetails.Text = "Edit Details";
            this.BtDoctorEditDetails.UseVisualStyleBackColor = true;
            this.BtDoctorEditDetails.Click += new System.EventHandler(this.BtDoctorEditDetails_Click);
            // 
            // FormDoctorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDoctorDetails";
            this.Text = " Doctor Details";
            this.Load += new System.EventHandler(this.FormDoctorDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointmentHistory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvAppointmentHistory;
        private System.Windows.Forms.RichTextBox RTbxDisease;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label LblDoctorIdentityNumber;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtAnnouncements;
        private System.Windows.Forms.Button BtDoctorEditDetails;
    }
}