namespace HospitalManagementAndAppointmentSystem
{
    partial class FormDepartmentPanel
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
            this.BtDepartmentUpdatePnl = new System.Windows.Forms.Button();
            this.BtDepartmentDeletePnl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDepartmentIdPnl = new System.Windows.Forms.TextBox();
            this.TxtDepartmentNamePnl = new System.Windows.Forms.TextBox();
            this.BtDepartmentInsertPnl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtDepartmentUpdatePnl
            // 
            this.BtDepartmentUpdatePnl.BackColor = System.Drawing.Color.Orange;
            this.BtDepartmentUpdatePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDepartmentUpdatePnl.Location = new System.Drawing.Point(38, 150);
            this.BtDepartmentUpdatePnl.Name = "BtDepartmentUpdatePnl";
            this.BtDepartmentUpdatePnl.Size = new System.Drawing.Size(216, 35);
            this.BtDepartmentUpdatePnl.TabIndex = 79;
            this.BtDepartmentUpdatePnl.Text = "Update";
            this.BtDepartmentUpdatePnl.UseVisualStyleBackColor = false;
            // 
            // BtDepartmentDeletePnl
            // 
            this.BtDepartmentDeletePnl.BackColor = System.Drawing.Color.Red;
            this.BtDepartmentDeletePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDepartmentDeletePnl.Location = new System.Drawing.Point(154, 108);
            this.BtDepartmentDeletePnl.Name = "BtDepartmentDeletePnl";
            this.BtDepartmentDeletePnl.Size = new System.Drawing.Size(100, 35);
            this.BtDepartmentDeletePnl.TabIndex = 78;
            this.BtDepartmentDeletePnl.Text = "Delete";
            this.BtDepartmentDeletePnl.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 166);
            this.dataGridView1.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 73;
            this.label7.Text = "Department Id:";
            // 
            // TxtDepartmentIdPnl
            // 
            this.TxtDepartmentIdPnl.Location = new System.Drawing.Point(185, 19);
            this.TxtDepartmentIdPnl.Name = "TxtDepartmentIdPnl";
            this.TxtDepartmentIdPnl.Size = new System.Drawing.Size(100, 27);
            this.TxtDepartmentIdPnl.TabIndex = 72;
            this.TxtDepartmentIdPnl.UseSystemPasswordChar = true;
            // 
            // TxtDepartmentNamePnl
            // 
            this.TxtDepartmentNamePnl.Location = new System.Drawing.Point(185, 55);
            this.TxtDepartmentNamePnl.Name = "TxtDepartmentNamePnl";
            this.TxtDepartmentNamePnl.Size = new System.Drawing.Size(100, 27);
            this.TxtDepartmentNamePnl.TabIndex = 70;
            this.TxtDepartmentNamePnl.UseSystemPasswordChar = true;
            // 
            // BtDepartmentInsertPnl
            // 
            this.BtDepartmentInsertPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtDepartmentInsertPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDepartmentInsertPnl.Location = new System.Drawing.Point(38, 108);
            this.BtDepartmentInsertPnl.Name = "BtDepartmentInsertPnl";
            this.BtDepartmentInsertPnl.Size = new System.Drawing.Size(100, 35);
            this.BtDepartmentInsertPnl.TabIndex = 67;
            this.BtDepartmentInsertPnl.Text = "Insert";
            this.BtDepartmentInsertPnl.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 80;
            this.label1.Text = "Department Name:";
            // 
            // FormDepartmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 198);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtDepartmentUpdatePnl);
            this.Controls.Add(this.BtDepartmentDeletePnl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDepartmentIdPnl);
            this.Controls.Add(this.TxtDepartmentNamePnl);
            this.Controls.Add(this.BtDepartmentInsertPnl);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDepartmentPanel";
            this.Text = "FormDepartmentPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtDepartmentUpdatePnl;
        private System.Windows.Forms.Button BtDepartmentDeletePnl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDepartmentIdPnl;
        private System.Windows.Forms.TextBox TxtDepartmentNamePnl;
        private System.Windows.Forms.Button BtDepartmentInsertPnl;
        private System.Windows.Forms.Label label1;
    }
}