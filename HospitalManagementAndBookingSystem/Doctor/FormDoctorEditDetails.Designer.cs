namespace HospitalManagementAndAppointmentSystem.Doctor
{
    partial class FormDoctorEditDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctorEditDetails));
            this.CbxDocDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDocName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDocSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MTxtDocIdentityNumber = new System.Windows.Forms.MaskedTextBox();
            this.BtDocUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDocPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbxDocDepartment
            // 
            this.CbxDocDepartment.FormattingEnabled = true;
            this.CbxDocDepartment.Location = new System.Drawing.Point(235, 175);
            this.CbxDocDepartment.Name = "CbxDocDepartment";
            this.CbxDocDepartment.Size = new System.Drawing.Size(100, 21);
            this.CbxDocDepartment.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(73, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 26);
            this.label7.TabIndex = 47;
            this.label7.Text = "Department:";
            // 
            // TxtDocName
            // 
            this.TxtDocName.Location = new System.Drawing.Point(235, 67);
            this.TxtDocName.Name = "TxtDocName";
            this.TxtDocName.Size = new System.Drawing.Size(100, 20);
            this.TxtDocName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(128, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 44;
            this.label6.Text = "Name:";
            // 
            // TxtDocSurname
            // 
            this.TxtDocSurname.Location = new System.Drawing.Point(235, 103);
            this.TxtDocSurname.Name = "TxtDocSurname";
            this.TxtDocSurname.Size = new System.Drawing.Size(100, 20);
            this.TxtDocSurname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(98, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 40;
            this.label4.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 34);
            this.label1.TabIndex = 39;
            this.label1.Text = "Doctor Edit Details";
            // 
            // MTxtDocIdentityNumber
            // 
            this.MTxtDocIdentityNumber.Location = new System.Drawing.Point(235, 139);
            this.MTxtDocIdentityNumber.Mask = "00000000000";
            this.MTxtDocIdentityNumber.Name = "MTxtDocIdentityNumber";
            this.MTxtDocIdentityNumber.Size = new System.Drawing.Size(100, 20);
            this.MTxtDocIdentityNumber.TabIndex = 3;
            this.MTxtDocIdentityNumber.ValidatingType = typeof(int);
            // 
            // BtDocUpdate
            // 
            this.BtDocUpdate.BackColor = System.Drawing.Color.Khaki;
            this.BtDocUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDocUpdate.Location = new System.Drawing.Point(235, 256);
            this.BtDocUpdate.Name = "BtDocUpdate";
            this.BtDocUpdate.Size = new System.Drawing.Size(100, 35);
            this.BtDocUpdate.TabIndex = 6;
            this.BtDocUpdate.Text = "Update";
            this.BtDocUpdate.UseVisualStyleBackColor = false;
            this.BtDocUpdate.Click += new System.EventHandler(this.BtDocUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "Identity Number:";
            // 
            // TxtDocPassword
            // 
            this.TxtDocPassword.Location = new System.Drawing.Point(235, 212);
            this.TxtDocPassword.Name = "TxtDocPassword";
            this.TxtDocPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtDocPassword.TabIndex = 5;
            this.TxtDocPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(91, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 26);
            this.label5.TabIndex = 49;
            this.label5.Text = "Password:";
            // 
            // FormDoctorEditDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(369, 301);
            this.Controls.Add(this.TxtDocPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxDocDepartment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDocName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDocSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MTxtDocIdentityNumber);
            this.Controls.Add(this.BtDocUpdate);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDoctorEditDetails";
            this.Text = " Doctor Edit Details";
            this.Load += new System.EventHandler(this.FormDoctorEditDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxDocDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDocName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDocSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MTxtDocIdentityNumber;
        private System.Windows.Forms.Button BtDocUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDocPassword;
        private System.Windows.Forms.Label label5;
    }
}