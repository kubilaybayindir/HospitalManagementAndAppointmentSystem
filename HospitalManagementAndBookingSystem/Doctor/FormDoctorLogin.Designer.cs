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
            this.TbxDocPassword = new System.Windows.Forms.TextBox();
            this.MTbxDocIdNumber = new System.Windows.Forms.MaskedTextBox();
            this.BtDocLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbxDocPassword
            // 
            this.TbxDocPassword.Location = new System.Drawing.Point(276, 168);
            this.TbxDocPassword.Name = "TbxDocPassword";
            this.TbxDocPassword.Size = new System.Drawing.Size(100, 20);
            this.TbxDocPassword.TabIndex = 12;
            this.TbxDocPassword.UseSystemPasswordChar = true;
            // 
            // MTbxDocIdNumber
            // 
            this.MTbxDocIdNumber.Location = new System.Drawing.Point(276, 124);
            this.MTbxDocIdNumber.Mask = "00000000000";
            this.MTbxDocIdNumber.Name = "MTbxDocIdNumber";
            this.MTbxDocIdNumber.Size = new System.Drawing.Size(100, 20);
            this.MTbxDocIdNumber.TabIndex = 11;
            this.MTbxDocIdNumber.ValidatingType = typeof(int);
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
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(540, 301);
            this.Controls.Add(this.TbxDocPassword);
            this.Controls.Add(this.MTbxDocIdNumber);
            this.Controls.Add(this.BtDocLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDoctorLogin";
            this.Text = "FormDoctorLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbxDocPassword;
        private System.Windows.Forms.MaskedTextBox MTbxDocIdNumber;
        private System.Windows.Forms.Button BtDocLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}