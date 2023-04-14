namespace HospitalManagementAndAppointmentSystem.Patient
{
    partial class FormPatientEditDetails
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
            this.CbxSex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MTxtIdentityNumber = new System.Windows.Forms.MaskedTextBox();
            this.BtPatientUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbxSex
            // 
            this.CbxSex.FormattingEnabled = true;
            this.CbxSex.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.CbxSex.Location = new System.Drawing.Point(244, 207);
            this.CbxSex.Name = "CbxSex";
            this.CbxSex.Size = new System.Drawing.Size(100, 21);
            this.CbxSex.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(158, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 26);
            this.label7.TabIndex = 33;
            this.label7.Text = "Sex:";
            // 
            // MTxtPhone
            // 
            this.MTxtPhone.Location = new System.Drawing.Point(244, 148);
            this.MTxtPhone.Mask = "(999) 000-0000";
            this.MTxtPhone.Name = "MTxtPhone";
            this.MTxtPhone.Size = new System.Drawing.Size(100, 21);
            this.MTxtPhone.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(244, 61);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 21);
            this.TxtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(137, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "Name:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(244, 177);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 21);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(100, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Password:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(244, 90);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(100, 21);
            this.TxtSurname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(107, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Patient Edit Details";
            // 
            // MTxtIdentityNumber
            // 
            this.MTxtIdentityNumber.Location = new System.Drawing.Point(244, 119);
            this.MTxtIdentityNumber.Mask = "00000000000";
            this.MTxtIdentityNumber.Name = "MTxtIdentityNumber";
            this.MTxtIdentityNumber.Size = new System.Drawing.Size(100, 21);
            this.MTxtIdentityNumber.TabIndex = 3;
            this.MTxtIdentityNumber.ValidatingType = typeof(int);
            // 
            // BtPatientUpdate
            // 
            this.BtPatientUpdate.BackColor = System.Drawing.Color.Khaki;
            this.BtPatientUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtPatientUpdate.Location = new System.Drawing.Point(244, 250);
            this.BtPatientUpdate.Name = "BtPatientUpdate";
            this.BtPatientUpdate.Size = new System.Drawing.Size(100, 35);
            this.BtPatientUpdate.TabIndex = 23;
            this.BtPatientUpdate.Text = "Update";
            this.BtPatientUpdate.UseVisualStyleBackColor = false;
            this.BtPatientUpdate.Click += new System.EventHandler(this.BtPatientUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(133, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Identity Number:";
            // 
            // FormPatientEditDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(369, 301);
            this.Controls.Add(this.CbxSex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MTxtPhone);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MTxtIdentityNumber);
            this.Controls.Add(this.BtPatientUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPatientEditDetails";
            this.Text = "Patient Edit Details";
            this.Load += new System.EventHandler(this.FormPatientEditDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MTxtPhone;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MTxtIdentityNumber;
        private System.Windows.Forms.Button BtPatientUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}