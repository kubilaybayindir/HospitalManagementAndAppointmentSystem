namespace HospitalManagementAndAppointmentSystem.Secretary
{
    partial class FormSecretaryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretaryDetails));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtCreateAnnouncement = new System.Windows.Forms.Button();
            this.RTbxSecAnnouncements = new System.Windows.Forms.RichTextBox();
            this.LblSecNameSurname = new System.Windows.Forms.Label();
            this.LblSecIdentityNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtAppointmentSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MTxtPatientIdNumber = new System.Windows.Forms.MaskedTextBox();
            this.MTxtHour = new System.Windows.Forms.MaskedTextBox();
            this.MTxtDate = new System.Windows.Forms.MaskedTextBox();
            this.TbxAppointmentIdNumber = new System.Windows.Forms.TextBox();
            this.CbxDoctor = new System.Windows.Forms.ComboBox();
            this.CbxDepartment = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvDepartments = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DgvDoctors = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtAnnouncementList = new System.Windows.Forms.Button();
            this.BtAppointmentList = new System.Windows.Forms.Button();
            this.BtDepartmentPanel = new System.Windows.Forms.Button();
            this.BtDoctorPanel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepartments)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctors)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtCreateAnnouncement);
            this.groupBox2.Controls.Add(this.RTbxSecAnnouncements);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(5, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 232);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Announcement";
            // 
            // BtCreateAnnouncement
            // 
            this.BtCreateAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtCreateAnnouncement.Location = new System.Drawing.Point(11, 192);
            this.BtCreateAnnouncement.Name = "BtCreateAnnouncement";
            this.BtCreateAnnouncement.Size = new System.Drawing.Size(260, 32);
            this.BtCreateAnnouncement.TabIndex = 7;
            this.BtCreateAnnouncement.Text = "Create Announcement";
            this.BtCreateAnnouncement.UseVisualStyleBackColor = true;
            this.BtCreateAnnouncement.Click += new System.EventHandler(this.BtCreateAnnouncement_Click);
            // 
            // RTbxSecAnnouncements
            // 
            this.RTbxSecAnnouncements.Location = new System.Drawing.Point(11, 28);
            this.RTbxSecAnnouncements.Name = "RTbxSecAnnouncements";
            this.RTbxSecAnnouncements.Size = new System.Drawing.Size(261, 158);
            this.RTbxSecAnnouncements.TabIndex = 6;
            this.RTbxSecAnnouncements.Text = "";
            // 
            // LblSecNameSurname
            // 
            this.LblSecNameSurname.AutoSize = true;
            this.LblSecNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSecNameSurname.Location = new System.Drawing.Point(152, 90);
            this.LblSecNameSurname.Name = "LblSecNameSurname";
            this.LblSecNameSurname.Size = new System.Drawing.Size(65, 20);
            this.LblSecNameSurname.TabIndex = 5;
            this.LblSecNameSurname.Text = "Null Null";
            // 
            // LblSecIdentityNumber
            // 
            this.LblSecIdentityNumber.AutoSize = true;
            this.LblSecIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSecIdentityNumber.Location = new System.Drawing.Point(152, 51);
            this.LblSecIdentityNumber.Name = "LblSecIdentityNumber";
            this.LblSecIdentityNumber.Size = new System.Drawing.Size(108, 20);
            this.LblSecIdentityNumber.TabIndex = 4;
            this.LblSecIdentityNumber.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name-Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identity Number:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtAppointmentSave);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.MTxtPatientIdNumber);
            this.groupBox3.Controls.Add(this.MTxtHour);
            this.groupBox3.Controls.Add(this.MTxtDate);
            this.groupBox3.Controls.Add(this.TbxAppointmentIdNumber);
            this.groupBox3.Controls.Add(this.CbxDoctor);
            this.groupBox3.Controls.Add(this.CbxDepartment);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(287, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 355);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Panel";
            // 
            // BtAppointmentSave
            // 
            this.BtAppointmentSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtAppointmentSave.Location = new System.Drawing.Point(9, 315);
            this.BtAppointmentSave.Name = "BtAppointmentSave";
            this.BtAppointmentSave.Size = new System.Drawing.Size(260, 32);
            this.BtAppointmentSave.TabIndex = 8;
            this.BtAppointmentSave.Text = "Save";
            this.BtAppointmentSave.UseVisualStyleBackColor = true;
            this.BtAppointmentSave.Click += new System.EventHandler(this.BtAppointmentSave_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(149, 270);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MTxtPatientIdNumber
            // 
            this.MTxtPatientIdNumber.Location = new System.Drawing.Point(149, 228);
            this.MTxtPatientIdNumber.Mask = "00000000000";
            this.MTxtPatientIdNumber.Name = "MTxtPatientIdNumber";
            this.MTxtPatientIdNumber.Size = new System.Drawing.Size(100, 26);
            this.MTxtPatientIdNumber.TabIndex = 18;
            this.MTxtPatientIdNumber.ValidatingType = typeof(int);
            // 
            // MTxtHour
            // 
            this.MTxtHour.Location = new System.Drawing.Point(149, 120);
            this.MTxtHour.Mask = "00:00";
            this.MTxtHour.Name = "MTxtHour";
            this.MTxtHour.Size = new System.Drawing.Size(100, 26);
            this.MTxtHour.TabIndex = 17;
            this.MTxtHour.ValidatingType = typeof(System.DateTime);
            // 
            // MTxtDate
            // 
            this.MTxtDate.Location = new System.Drawing.Point(149, 84);
            this.MTxtDate.Mask = "00/00/0000";
            this.MTxtDate.Name = "MTxtDate";
            this.MTxtDate.Size = new System.Drawing.Size(100, 26);
            this.MTxtDate.TabIndex = 16;
            this.MTxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // TbxAppointmentIdNumber
            // 
            this.TbxAppointmentIdNumber.Location = new System.Drawing.Point(149, 48);
            this.TbxAppointmentIdNumber.Name = "TbxAppointmentIdNumber";
            this.TbxAppointmentIdNumber.Size = new System.Drawing.Size(138, 26);
            this.TbxAppointmentIdNumber.TabIndex = 11;
            // 
            // CbxDoctor
            // 
            this.CbxDoctor.DisplayMember = "Doctor";
            this.CbxDoctor.FormattingEnabled = true;
            this.CbxDoctor.Location = new System.Drawing.Point(149, 191);
            this.CbxDoctor.Name = "CbxDoctor";
            this.CbxDoctor.Size = new System.Drawing.Size(138, 28);
            this.CbxDoctor.TabIndex = 10;
            this.CbxDoctor.ValueMember = "Doctor";
            // 
            // CbxDepartment
            // 
            this.CbxDepartment.DisplayMember = "Department";
            this.CbxDepartment.FormattingEnabled = true;
            this.CbxDepartment.Location = new System.Drawing.Point(149, 155);
            this.CbxDepartment.Name = "CbxDepartment";
            this.CbxDepartment.Size = new System.Drawing.Size(138, 28);
            this.CbxDepartment.TabIndex = 9;
            this.CbxDepartment.ValueMember = "Department";
            this.CbxDepartment.SelectedIndexChanged += new System.EventHandler(this.CbxDepartment_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(94, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "State:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(5, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Patient Id Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(85, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Doctor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(48, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(98, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(98, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Identity Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblSecNameSurname);
            this.groupBox1.Controls.Add(this.LblSecIdentityNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(5, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Details";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvDepartments);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(585, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 225);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Departments";
            // 
            // DgvDepartments
            // 
            this.DgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDepartments.Location = new System.Drawing.Point(3, 22);
            this.DgvDepartments.Name = "DgvDepartments";
            this.DgvDepartments.Size = new System.Drawing.Size(206, 200);
            this.DgvDepartments.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DgvDoctors);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(585, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(212, 223);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // DgvDoctors
            // 
            this.DgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDoctors.Location = new System.Drawing.Point(3, 22);
            this.DgvDoctors.Name = "DgvDoctors";
            this.DgvDoctors.Size = new System.Drawing.Size(206, 198);
            this.DgvDoctors.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtAnnouncementList);
            this.groupBox6.Controls.Add(this.BtAppointmentList);
            this.groupBox6.Controls.Add(this.BtDepartmentPanel);
            this.groupBox6.Controls.Add(this.BtDoctorPanel);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(5, 363);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(577, 84);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Shortcut Access";
            // 
            // BtAnnouncementList
            // 
            this.BtAnnouncementList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtAnnouncementList.Location = new System.Drawing.Point(442, 25);
            this.BtAnnouncementList.Name = "BtAnnouncementList";
            this.BtAnnouncementList.Size = new System.Drawing.Size(127, 53);
            this.BtAnnouncementList.TabIndex = 24;
            this.BtAnnouncementList.Text = "Announcement List";
            this.BtAnnouncementList.UseVisualStyleBackColor = true;
            this.BtAnnouncementList.Click += new System.EventHandler(this.BtAnnouncementList_Click);
            // 
            // BtAppointmentList
            // 
            this.BtAppointmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtAppointmentList.Location = new System.Drawing.Point(298, 25);
            this.BtAppointmentList.Name = "BtAppointmentList";
            this.BtAppointmentList.Size = new System.Drawing.Size(127, 53);
            this.BtAppointmentList.TabIndex = 23;
            this.BtAppointmentList.Text = "Appointment List";
            this.BtAppointmentList.UseVisualStyleBackColor = true;
            this.BtAppointmentList.Click += new System.EventHandler(this.BtAppointmentList_Click);
            // 
            // BtDepartmentPanel
            // 
            this.BtDepartmentPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDepartmentPanel.Location = new System.Drawing.Point(154, 25);
            this.BtDepartmentPanel.Name = "BtDepartmentPanel";
            this.BtDepartmentPanel.Size = new System.Drawing.Size(127, 53);
            this.BtDepartmentPanel.TabIndex = 22;
            this.BtDepartmentPanel.Text = "Department Panel";
            this.BtDepartmentPanel.UseVisualStyleBackColor = true;
            this.BtDepartmentPanel.Click += new System.EventHandler(this.BtDepartmentPanel_Click);
            // 
            // BtDoctorPanel
            // 
            this.BtDoctorPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDoctorPanel.Location = new System.Drawing.Point(10, 25);
            this.BtDoctorPanel.Name = "BtDoctorPanel";
            this.BtDoctorPanel.Size = new System.Drawing.Size(127, 53);
            this.BtDoctorPanel.TabIndex = 21;
            this.BtDoctorPanel.Text = "Doctor \r\nPanel";
            this.BtDoctorPanel.UseVisualStyleBackColor = true;
            this.BtDoctorPanel.Click += new System.EventHandler(this.BtDoctorPanel_Click);
            // 
            // FormSecretaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSecretaryDetails";
            this.Text = "Secretary Details";
            this.Load += new System.EventHandler(this.FormSecretaryDetails_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepartments)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctors)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtCreateAnnouncement;
        private System.Windows.Forms.RichTextBox RTbxSecAnnouncements;
        private System.Windows.Forms.Label LblSecNameSurname;
        private System.Windows.Forms.Label LblSecIdentityNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxDoctor;
        private System.Windows.Forms.ComboBox CbxDepartment;
        private System.Windows.Forms.Button BtAppointmentSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox MTxtPatientIdNumber;
        private System.Windows.Forms.MaskedTextBox MTxtHour;
        private System.Windows.Forms.MaskedTextBox MTxtDate;
        private System.Windows.Forms.TextBox TbxAppointmentIdNumber;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DgvDepartments;
        private System.Windows.Forms.DataGridView DgvDoctors;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtAppointmentList;
        private System.Windows.Forms.Button BtDepartmentPanel;
        private System.Windows.Forms.Button BtDoctorPanel;
        private System.Windows.Forms.Button BtAnnouncementList;
    }
}