namespace HospitalManagementAndAppointmentSystem.Patient
{
    partial class FormPatientDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblPatientNameSurname = new System.Windows.Forms.Label();
            this.LblPatientIdentityNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LLblEditDetails = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtMakeAppointment = new System.Windows.Forms.Button();
            this.RTbxDisease = new System.Windows.Forms.RichTextBox();
            this.CbxPatientDoctor = new System.Windows.Forms.ComboBox();
            this.CbxPatientDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvAppointmentHistory = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvActiveAppointment = new System.Windows.Forms.DataGridView();
            this.LblGeneratePatient = new System.Windows.Forms.LinkLabel();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointmentHistory)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActiveAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblPatientNameSurname);
            this.groupBox1.Controls.Add(this.LblPatientIdentityNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(5, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // LblPatientNameSurname
            // 
            this.LblPatientNameSurname.AutoSize = true;
            this.LblPatientNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPatientNameSurname.Location = new System.Drawing.Point(149, 90);
            this.LblPatientNameSurname.Name = "LblPatientNameSurname";
            this.LblPatientNameSurname.Size = new System.Drawing.Size(81, 24);
            this.LblPatientNameSurname.TabIndex = 5;
            this.LblPatientNameSurname.Text = "Null Null";
            // 
            // LblPatientIdentityNumber
            // 
            this.LblPatientIdentityNumber.AutoSize = true;
            this.LblPatientIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPatientIdentityNumber.Location = new System.Drawing.Point(149, 51);
            this.LblPatientIdentityNumber.Name = "LblPatientIdentityNumber";
            this.LblPatientIdentityNumber.Size = new System.Drawing.Size(120, 24);
            this.LblPatientIdentityNumber.TabIndex = 4;
            this.LblPatientIdentityNumber.Text = "00000000000";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtId);
            this.groupBox2.Controls.Add(this.LblGeneratePatient);
            this.groupBox2.Controls.Add(this.LLblEditDetails);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BtMakeAppointment);
            this.groupBox2.Controls.Add(this.RTbxDisease);
            this.groupBox2.Controls.Add(this.CbxPatientDoctor);
            this.groupBox2.Controls.Add(this.CbxPatientDepartment);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(5, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Panel";
            // 
            // LLblEditDetails
            // 
            this.LLblEditDetails.AutoSize = true;
            this.LLblEditDetails.Location = new System.Drawing.Point(7, 218);
            this.LLblEditDetails.Name = "LLblEditDetails";
            this.LLblEditDetails.Size = new System.Drawing.Size(102, 24);
            this.LLblEditDetails.TabIndex = 9;
            this.LLblEditDetails.TabStop = true;
            this.LLblEditDetails.Text = "Edit Details";
            this.LLblEditDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLblEditDetails_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Disease:";
            // 
            // BtMakeAppointment
            // 
            this.BtMakeAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtMakeAppointment.Location = new System.Drawing.Point(140, 203);
            this.BtMakeAppointment.Name = "BtMakeAppointment";
            this.BtMakeAppointment.Size = new System.Drawing.Size(138, 39);
            this.BtMakeAppointment.TabIndex = 7;
            this.BtMakeAppointment.Text = "Make Appointment";
            this.BtMakeAppointment.UseVisualStyleBackColor = true;
            // 
            // RTbxDisease
            // 
            this.RTbxDisease.Location = new System.Drawing.Point(140, 133);
            this.RTbxDisease.Name = "RTbxDisease";
            this.RTbxDisease.Size = new System.Drawing.Size(138, 66);
            this.RTbxDisease.TabIndex = 6;
            this.RTbxDisease.Text = "";
            // 
            // CbxPatientDoctor
            // 
            this.CbxPatientDoctor.FormattingEnabled = true;
            this.CbxPatientDoctor.Location = new System.Drawing.Point(140, 100);
            this.CbxPatientDoctor.Name = "CbxPatientDoctor";
            this.CbxPatientDoctor.Size = new System.Drawing.Size(138, 32);
            this.CbxPatientDoctor.TabIndex = 5;
            this.CbxPatientDoctor.SelectedIndexChanged += new System.EventHandler(this.CbxPatientDoctor_SelectedIndexChanged);
            // 
            // CbxPatientDepartment
            // 
            this.CbxPatientDepartment.FormattingEnabled = true;
            this.CbxPatientDepartment.Location = new System.Drawing.Point(140, 66);
            this.CbxPatientDepartment.Name = "CbxPatientDepartment";
            this.CbxPatientDepartment.Size = new System.Drawing.Size(138, 32);
            this.CbxPatientDepartment.TabIndex = 4;
            this.CbxPatientDepartment.SelectedIndexChanged += new System.EventHandler(this.CbxPatientDepartment_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doctor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Department:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvAppointmentHistory);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(305, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 170);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment History";
            // 
            // DgvAppointmentHistory
            // 
            this.DgvAppointmentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAppointmentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAppointmentHistory.Location = new System.Drawing.Point(3, 25);
            this.DgvAppointmentHistory.Name = "DgvAppointmentHistory";
            this.DgvAppointmentHistory.Size = new System.Drawing.Size(484, 142);
            this.DgvAppointmentHistory.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvActiveAppointment);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(305, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(490, 252);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Appointments";
            // 
            // DgvActiveAppointment
            // 
            this.DgvActiveAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvActiveAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvActiveAppointment.Location = new System.Drawing.Point(3, 25);
            this.DgvActiveAppointment.Name = "DgvActiveAppointment";
            this.DgvActiveAppointment.Size = new System.Drawing.Size(484, 224);
            this.DgvActiveAppointment.TabIndex = 1;
            // 
            // LblGeneratePatient
            // 
            this.LblGeneratePatient.AutoSize = true;
            this.LblGeneratePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGeneratePatient.Location = new System.Drawing.Point(7, 192);
            this.LblGeneratePatient.Name = "LblGeneratePatient";
            this.LblGeneratePatient.Size = new System.Drawing.Size(116, 17);
            this.LblGeneratePatient.TabIndex = 10;
            this.LblGeneratePatient.TabStop = true;
            this.LblGeneratePatient.Text = "Generate Patient";
            this.LblGeneratePatient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblGeneratePatient_LinkClicked);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(140, 31);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(138, 29);
            this.TxtId.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(90, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id:";
            // 
            // FormPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPatientDetails";
            this.Text = "FormPatientDetails";
            this.Load += new System.EventHandler(this.FormPatientDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointmentHistory)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvActiveAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LLblEditDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtMakeAppointment;
        private System.Windows.Forms.RichTextBox RTbxDisease;
        private System.Windows.Forms.ComboBox CbxPatientDoctor;
        private System.Windows.Forms.ComboBox CbxPatientDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvAppointmentHistory;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DgvActiveAppointment;
        private System.Windows.Forms.Label LblPatientNameSurname;
        private System.Windows.Forms.Label LblPatientIdentityNumber;
        private System.Windows.Forms.LinkLabel LblGeneratePatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtId;
    }
}