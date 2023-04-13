namespace HospitalManagementAndAppointmentSystem
{
    partial class FormPatientLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtPatientLogin = new System.Windows.Forms.Button();
            this.MTbxPatientLgnIdNumber = new System.Windows.Forms.MaskedTextBox();
            this.TbxPatientLgnPassword = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Login Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identity Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // BtPatientLogin
            // 
            this.BtPatientLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtPatientLogin.Location = new System.Drawing.Point(235, 186);
            this.BtPatientLogin.Name = "BtPatientLogin";
            this.BtPatientLogin.Size = new System.Drawing.Size(100, 35);
            this.BtPatientLogin.TabIndex = 3;
            this.BtPatientLogin.Text = "Login";
            this.BtPatientLogin.UseVisualStyleBackColor = true;
            this.BtPatientLogin.Click += new System.EventHandler(this.BtPatientLogin_Click);
            // 
            // MTbxPatientLgnIdNumber
            // 
            this.MTbxPatientLgnIdNumber.Location = new System.Drawing.Point(235, 99);
            this.MTbxPatientLgnIdNumber.Mask = "00000000000";
            this.MTbxPatientLgnIdNumber.Name = "MTbxPatientLgnIdNumber";
            this.MTbxPatientLgnIdNumber.Size = new System.Drawing.Size(100, 20);
            this.MTbxPatientLgnIdNumber.TabIndex = 1;
            this.MTbxPatientLgnIdNumber.ValidatingType = typeof(int);
            // 
            // TbxPatientLgnPassword
            // 
            this.TbxPatientLgnPassword.Location = new System.Drawing.Point(235, 143);
            this.TbxPatientLgnPassword.Name = "TbxPatientLgnPassword";
            this.TbxPatientLgnPassword.Size = new System.Drawing.Size(100, 20);
            this.TbxPatientLgnPassword.TabIndex = 2;
            this.TbxPatientLgnPassword.UseSystemPasswordChar = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(364, 191);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 24);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormPatientLogin
            // 
            this.AcceptButton = this.BtPatientLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(540, 301);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TbxPatientLgnPassword);
            this.Controls.Add(this.MTbxPatientLgnIdNumber);
            this.Controls.Add(this.BtPatientLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPatientLogin";
            this.Text = "Patient Login";
            this.Load += new System.EventHandler(this.FormPatientLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtPatientLogin;
        private System.Windows.Forms.MaskedTextBox MTbxPatientLgnIdNumber;
        private System.Windows.Forms.TextBox TbxPatientLgnPassword;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}