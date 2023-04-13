namespace HospitalManagementAndAppointmentSystem
{
    partial class FormLogins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogins));
            this.BtPatientScreenOpen = new System.Windows.Forms.Button();
            this.BtDoctorScreenOpen = new System.Windows.Forms.Button();
            this.BtSecretaryScreenOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtPatientScreenOpen
            // 
            this.BtPatientScreenOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtPatientScreenOpen.BackgroundImage")));
            this.BtPatientScreenOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtPatientScreenOpen.Location = new System.Drawing.Point(31, 103);
            this.BtPatientScreenOpen.Name = "BtPatientScreenOpen";
            this.BtPatientScreenOpen.Size = new System.Drawing.Size(192, 144);
            this.BtPatientScreenOpen.TabIndex = 0;
            this.BtPatientScreenOpen.UseVisualStyleBackColor = true;
            this.BtPatientScreenOpen.Click += new System.EventHandler(this.BtPatientScreenOpen_Click);
            // 
            // BtDoctorScreenOpen
            // 
            this.BtDoctorScreenOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtDoctorScreenOpen.BackgroundImage")));
            this.BtDoctorScreenOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtDoctorScreenOpen.Location = new System.Drawing.Point(247, 103);
            this.BtDoctorScreenOpen.Name = "BtDoctorScreenOpen";
            this.BtDoctorScreenOpen.Size = new System.Drawing.Size(192, 144);
            this.BtDoctorScreenOpen.TabIndex = 1;
            this.BtDoctorScreenOpen.UseVisualStyleBackColor = true;
            this.BtDoctorScreenOpen.Click += new System.EventHandler(this.BtDoctorScreenOpen_Click);
            // 
            // BtSecretaryScreenOpen
            // 
            this.BtSecretaryScreenOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSecretaryScreenOpen.BackgroundImage")));
            this.BtSecretaryScreenOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtSecretaryScreenOpen.Location = new System.Drawing.Point(463, 103);
            this.BtSecretaryScreenOpen.Name = "BtSecretaryScreenOpen";
            this.BtSecretaryScreenOpen.Size = new System.Drawing.Size(192, 144);
            this.BtSecretaryScreenOpen.TabIndex = 2;
            this.BtSecretaryScreenOpen.UseVisualStyleBackColor = true;
            this.BtSecretaryScreenOpen.Click += new System.EventHandler(this.BtSecretaryScreenOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(296, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(497, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Secretary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtSecretaryScreenOpen);
            this.Controls.Add(this.BtDoctorScreenOpen);
            this.Controls.Add(this.BtPatientScreenOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogins";
            this.Text = "Hospital Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtPatientScreenOpen;
        private System.Windows.Forms.Button BtDoctorScreenOpen;
        private System.Windows.Forms.Button BtSecretaryScreenOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

