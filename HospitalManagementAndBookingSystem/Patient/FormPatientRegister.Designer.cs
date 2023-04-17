namespace HospitalManagementAndAppointmentSystem
{
    partial class FormPatientRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatientRegister));
            this.MTxtPatientRegIdentityNumber = new System.Windows.Forms.MaskedTextBox();
            this.BtRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPatientRegSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPatientRegPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPatientRegName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MTxtPatientRegPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxPatientRegSex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MTxtPatientRegIdentityNumber
            // 
            this.MTxtPatientRegIdentityNumber.Location = new System.Drawing.Point(243, 121);
            this.MTxtPatientRegIdentityNumber.Mask = "00000000000";
            this.MTxtPatientRegIdentityNumber.Name = "MTxtPatientRegIdentityNumber";
            this.MTxtPatientRegIdentityNumber.Size = new System.Drawing.Size(100, 20);
            this.MTxtPatientRegIdentityNumber.TabIndex = 3;
            this.MTxtPatientRegIdentityNumber.ValidatingType = typeof(int);
            // 
            // BtRegister
            // 
            this.BtRegister.BackColor = System.Drawing.Color.Khaki;
            this.BtRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtRegister.Location = new System.Drawing.Point(243, 252);
            this.BtRegister.Name = "BtRegister";
            this.BtRegister.Size = new System.Drawing.Size(100, 35);
            this.BtRegister.TabIndex = 7;
            this.BtRegister.Text = "Register";
            this.BtRegister.UseVisualStyleBackColor = false;
            this.BtRegister.Click += new System.EventHandler(this.BtRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(132, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Identity Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient Register Panel";
            // 
            // TxtPatientRegSurname
            // 
            this.TxtPatientRegSurname.Location = new System.Drawing.Point(243, 92);
            this.TxtPatientRegSurname.Name = "TxtPatientRegSurname";
            this.TxtPatientRegSurname.Size = new System.Drawing.Size(100, 20);
            this.TxtPatientRegSurname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(106, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Surname:";
            // 
            // TxtPatientRegPassword
            // 
            this.TxtPatientRegPassword.Location = new System.Drawing.Point(243, 179);
            this.TxtPatientRegPassword.Name = "TxtPatientRegPassword";
            this.TxtPatientRegPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtPatientRegPassword.TabIndex = 5;
            this.TxtPatientRegPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(99, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password:";
            // 
            // TxtPatientRegName
            // 
            this.TxtPatientRegName.Location = new System.Drawing.Point(243, 63);
            this.TxtPatientRegName.Name = "TxtPatientRegName";
            this.TxtPatientRegName.Size = new System.Drawing.Size(100, 20);
            this.TxtPatientRegName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(136, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name:";
            // 
            // MTxtPatientRegPhone
            // 
            this.MTxtPatientRegPhone.Location = new System.Drawing.Point(243, 150);
            this.MTxtPatientRegPhone.Mask = "(999) 000-0000";
            this.MTxtPatientRegPhone.Name = "MTxtPatientRegPhone";
            this.MTxtPatientRegPhone.Size = new System.Drawing.Size(100, 20);
            this.MTxtPatientRegPhone.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(157, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sex:";
            // 
            // CbxPatientRegSex
            // 
            this.CbxPatientRegSex.FormattingEnabled = true;
            this.CbxPatientRegSex.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.CbxPatientRegSex.Location = new System.Drawing.Point(243, 209);
            this.CbxPatientRegSex.Name = "CbxPatientRegSex";
            this.CbxPatientRegSex.Size = new System.Drawing.Size(100, 21);
            this.CbxPatientRegSex.TabIndex = 6;
            // 
            // FormPatientRegister
            // 
            this.AcceptButton = this.BtRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(369, 301);
            this.Controls.Add(this.CbxPatientRegSex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MTxtPatientRegPhone);
            this.Controls.Add(this.TxtPatientRegName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPatientRegPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPatientRegSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MTxtPatientRegIdentityNumber);
            this.Controls.Add(this.BtRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPatientRegister";
            this.Text = "Patient Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox MTxtPatientRegIdentityNumber;
        private System.Windows.Forms.Button BtRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPatientRegSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPatientRegPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPatientRegName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MTxtPatientRegPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxPatientRegSex;
    }
}