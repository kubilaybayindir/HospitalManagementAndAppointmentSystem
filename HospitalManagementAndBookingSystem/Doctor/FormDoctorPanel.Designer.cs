namespace HospitalManagementAndAppointmentSystem.Doctor
{
    partial class FormDoctorPanel
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
            this.TxtDocPasswordPnl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxDocDepartmentPnl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDocNamePnl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDocSurnamePnl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MTxtDocIdentityNumberPnl = new System.Windows.Forms.MaskedTextBox();
            this.BtDocInsertPnl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvDoctors = new System.Windows.Forms.DataGridView();
            this.BtDocDeletePnl = new System.Windows.Forms.Button();
            this.BtDocUpdatePnl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDocPasswordPnl
            // 
            this.TxtDocPasswordPnl.Location = new System.Drawing.Point(168, 167);
            this.TxtDocPasswordPnl.Name = "TxtDocPasswordPnl";
            this.TxtDocPasswordPnl.Size = new System.Drawing.Size(100, 20);
            this.TxtDocPasswordPnl.TabIndex = 5;
            this.TxtDocPasswordPnl.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(60, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Password:";
            // 
            // CbxDocDepartmentPnl
            // 
            this.CbxDocDepartmentPnl.FormattingEnabled = true;
            this.CbxDocDepartmentPnl.Location = new System.Drawing.Point(168, 95);
            this.CbxDocDepartmentPnl.Name = "CbxDocDepartmentPnl";
            this.CbxDocDepartmentPnl.Size = new System.Drawing.Size(100, 21);
            this.CbxDocDepartmentPnl.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(45, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 59;
            this.label7.Text = "Department:";
            // 
            // TxtDocNamePnl
            // 
            this.TxtDocNamePnl.Location = new System.Drawing.Point(168, 23);
            this.TxtDocNamePnl.Name = "TxtDocNamePnl";
            this.TxtDocNamePnl.Size = new System.Drawing.Size(100, 20);
            this.TxtDocNamePnl.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(91, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Name:";
            // 
            // TxtDocSurnamePnl
            // 
            this.TxtDocSurnamePnl.Location = new System.Drawing.Point(168, 59);
            this.TxtDocSurnamePnl.Name = "TxtDocSurnamePnl";
            this.TxtDocSurnamePnl.Size = new System.Drawing.Size(100, 20);
            this.TxtDocSurnamePnl.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "Surname:";
            // 
            // MTxtDocIdentityNumberPnl
            // 
            this.MTxtDocIdentityNumberPnl.Location = new System.Drawing.Point(168, 131);
            this.MTxtDocIdentityNumberPnl.Mask = "00000000000";
            this.MTxtDocIdentityNumberPnl.Name = "MTxtDocIdentityNumberPnl";
            this.MTxtDocIdentityNumberPnl.Size = new System.Drawing.Size(100, 20);
            this.MTxtDocIdentityNumberPnl.TabIndex = 4;
            this.MTxtDocIdentityNumberPnl.ValidatingType = typeof(int);
            // 
            // BtDocInsertPnl
            // 
            this.BtDocInsertPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtDocInsertPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDocInsertPnl.Location = new System.Drawing.Point(63, 212);
            this.BtDocInsertPnl.Name = "BtDocInsertPnl";
            this.BtDocInsertPnl.Size = new System.Drawing.Size(100, 35);
            this.BtDocInsertPnl.TabIndex = 52;
            this.BtDocInsertPnl.Text = "Insert";
            this.BtDocInsertPnl.UseVisualStyleBackColor = false;
            this.BtDocInsertPnl.Click += new System.EventHandler(this.BtDocInsertPnl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Identity Number:";
            // 
            // DgvDoctors
            // 
            this.DgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDoctors.Location = new System.Drawing.Point(290, 23);
            this.DgvDoctors.Name = "DgvDoctors";
            this.DgvDoctors.Size = new System.Drawing.Size(336, 266);
            this.DgvDoctors.TabIndex = 63;
            this.DgvDoctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoctors_CellClick);
            // 
            // BtDocDeletePnl
            // 
            this.BtDocDeletePnl.BackColor = System.Drawing.Color.Red;
            this.BtDocDeletePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDocDeletePnl.Location = new System.Drawing.Point(168, 212);
            this.BtDocDeletePnl.Name = "BtDocDeletePnl";
            this.BtDocDeletePnl.Size = new System.Drawing.Size(100, 35);
            this.BtDocDeletePnl.TabIndex = 64;
            this.BtDocDeletePnl.Text = "Delete";
            this.BtDocDeletePnl.UseVisualStyleBackColor = false;
            this.BtDocDeletePnl.Click += new System.EventHandler(this.BtDocDeletePnl_Click);
            // 
            // BtDocUpdatePnl
            // 
            this.BtDocUpdatePnl.BackColor = System.Drawing.Color.Orange;
            this.BtDocUpdatePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDocUpdatePnl.Location = new System.Drawing.Point(63, 254);
            this.BtDocUpdatePnl.Name = "BtDocUpdatePnl";
            this.BtDocUpdatePnl.Size = new System.Drawing.Size(205, 35);
            this.BtDocUpdatePnl.TabIndex = 65;
            this.BtDocUpdatePnl.Text = "Update";
            this.BtDocUpdatePnl.UseVisualStyleBackColor = false;
            this.BtDocUpdatePnl.Click += new System.EventHandler(this.BtDocUpdatePnl_Click);
            // 
            // FormDoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(638, 301);
            this.Controls.Add(this.BtDocUpdatePnl);
            this.Controls.Add(this.BtDocDeletePnl);
            this.Controls.Add(this.DgvDoctors);
            this.Controls.Add(this.TxtDocPasswordPnl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxDocDepartmentPnl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDocNamePnl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDocSurnamePnl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MTxtDocIdentityNumberPnl);
            this.Controls.Add(this.BtDocInsertPnl);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDoctorPanel";
            this.Text = " Doctor Panel";
            this.Load += new System.EventHandler(this.FormDoctorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDocPasswordPnl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbxDocDepartmentPnl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDocNamePnl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDocSurnamePnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MTxtDocIdentityNumberPnl;
        private System.Windows.Forms.Button BtDocInsertPnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvDoctors;
        private System.Windows.Forms.Button BtDocDeletePnl;
        private System.Windows.Forms.Button BtDocUpdatePnl;
    }
}