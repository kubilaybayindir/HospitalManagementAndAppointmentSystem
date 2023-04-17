namespace HospitalManagementAndAppointmentSystem
{
    partial class FormDoctorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctorLogin));
            this.TbxDoctorPassword = new System.Windows.Forms.TextBox();
            this.MTbxDoctorIdNumber = new System.Windows.Forms.MaskedTextBox();
            this.BtDocLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbxDoctorPassword
            // 
            this.TbxDoctorPassword.Location = new System.Drawing.Point(276, 168);
            this.TbxDoctorPassword.Name = "TbxDoctorPassword";
            this.TbxDoctorPassword.Size = new System.Drawing.Size(100, 20);
            this.TbxDoctorPassword.TabIndex = 12;
            this.TbxDoctorPassword.UseSystemPasswordChar = true;
            // 
            // MTbxDoctorIdNumber
            // 
            this.MTbxDoctorIdNumber.Location = new System.Drawing.Point(276, 124);
            this.MTbxDoctorIdNumber.Mask = "00000000000";
            this.MTbxDoctorIdNumber.Name = "MTbxDoctorIdNumber";
            this.MTbxDoctorIdNumber.Size = new System.Drawing.Size(100, 20);
            this.MTbxDoctorIdNumber.TabIndex = 11;
            this.MTbxDoctorIdNumber.ValidatingType = typeof(int);
            // 
            // BtDocLogin
            // 
            this.BtDocLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDocLogin.Location = new System.Drawing.Point(276, 211);
            this.BtDocLogin.Name = "BtDocLogin";
            this.BtDocLogin.Size = new System.Drawing.Size(100, 35);
            this.BtDocLogin.TabIndex = 10;
            this.BtDocLogin.Text = "Login";
            this.BtDocLogin.UseVisualStyleBackColor = true;
            this.BtDocLogin.Click += new System.EventHandler(this.BtDocLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(146, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Identity Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doctor Login Panel";
            // 
            // FormDoctorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(446, 301);
            this.Controls.Add(this.TbxDoctorPassword);
            this.Controls.Add(this.MTbxDoctorIdNumber);
            this.Controls.Add(this.BtDocLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDoctorLogin";
            this.Text = " Doctor Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbxDoctorPassword;
        private System.Windows.Forms.MaskedTextBox MTbxDoctorIdNumber;
        private System.Windows.Forms.Button BtDocLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}