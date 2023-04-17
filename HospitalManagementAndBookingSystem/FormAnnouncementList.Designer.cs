namespace HospitalManagementAndAppointmentSystem
{
    partial class FormAnnouncementList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnnouncementList));
            this.DgvAnnouncementList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnnouncementList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAnnouncementList
            // 
            this.DgvAnnouncementList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAnnouncementList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAnnouncementList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAnnouncementList.Location = new System.Drawing.Point(0, 0);
            this.DgvAnnouncementList.Name = "DgvAnnouncementList";
            this.DgvAnnouncementList.ReadOnly = true;
            this.DgvAnnouncementList.Size = new System.Drawing.Size(627, 494);
            this.DgvAnnouncementList.TabIndex = 1;
            // 
            // FormAnnouncementList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(627, 494);
            this.Controls.Add(this.DgvAnnouncementList);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnnouncementList";
            this.Text = " Announcement List";
            this.Load += new System.EventHandler(this.FormAnnouncementList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnnouncementList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAnnouncementList;
    }
}