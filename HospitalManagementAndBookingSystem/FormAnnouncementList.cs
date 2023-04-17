using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementAndAppointmentSystem
{
    public partial class FormAnnouncementList : Form
    {
        public FormAnnouncementList()
        {
            InitializeComponent();
        }
        SQLConnectionCls sqlConnectionCls = new SQLConnectionCls();
        private void FormAnnouncementList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Announcement", sqlConnectionCls.ConnectDb());
            sqlDataAdapter.Fill(dt);
            DgvAnnouncementList.DataSource = dt;
        }
    }
}
