namespace HospitalManagementAndAppointmentSystem
{
    partial class FormSecretaryLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretaryLogin));
            this.TbxSecPassword = new System.Windows.Forms.TextBox();
            this.MTbxSecIdNumber = new System.Windows.Forms.MaskedTextBox();
            this.BtPatientLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbxSecPassword
            // 
            this.TbxSecPassword.Location = new System.Drawing.Point(261, 166);
            this.TbxSecPassword.Name = "TbxSecPassword";
            this.TbxSecPassword.Size = new System.Drawing.Size(100, 20);
            this.TbxSecPassword.TabIndex = 12;
            this.TbxSecPassword.Text = "123123";
            this.TbxSecPassword.UseSystemPasswordChar = true;
            // 
            // MTbxSecIdNumber
            // 
            this.MTbxSecIdNumber.Location = new System.Drawing.Point(261, 122);
            this.MTbxSecIdNumber.Mask = "00000000000";
            this.MTbxSecIdNumber.Name = "MTbxSecIdNumber";
            this.MTbxSecIdNumber.Size = new System.Drawing.Size(100, 20);
            this.MTbxSecIdNumber.TabIndex = 11;
            this.MTbxSecIdNumber.Text = "98765432112";
            this.MTbxSecIdNumber.ValidatingType = typeof(int);
            // 
            // BtPatientLogin
            // 
            this.BtPatientLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtPatientLogin.Location = new System.Drawing.Point(261, 209);
            this.BtPatientLogin.Name = "BtPatientLogin";
            this.BtPatientLogin.Size = new System.Drawing.Size(100, 35);
            this.BtPatientLogin.TabIndex = 10;
            this.BtPatientLogin.Text = "Login";
            this.BtPatientLogin.UseVisualStyleBackColor = true;
            this.BtPatientLogin.Click += new System.EventHandler(this.BtPatientLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(131, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Identity Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Secretary Login Panel";
            // 
            // FormSecretaryLogin
            // 
            this.AcceptButton = this.BtPatientLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(446, 301);
            this.Controls.Add(this.TbxSecPassword);
            this.Controls.Add(this.MTbxSecIdNumber);
            this.Controls.Add(this.BtPatientLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSecretaryLogin";
            this.Text = " Secretary Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxSecPassword;
        private System.Windows.Forms.MaskedTextBox MTbxSecIdNumber;
        private System.Windows.Forms.Button BtPatientLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}