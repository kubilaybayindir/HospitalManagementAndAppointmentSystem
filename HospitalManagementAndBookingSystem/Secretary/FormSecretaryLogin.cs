using HospitalManagementAndAppointmentSystem.Secretary;
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
    public partial class FormSecretaryLogin : Form
    {
        public FormSecretaryLogin()
        {
            InitializeComponent();
        }
        SQLConnectionCls sqLConnectionCls = new SQLConnectionCls();
        private void BtPatientLogin_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Secretary WHERE IdentityNumber=@p1 AND Password=@p2", sqLConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@p1", MTbxPatientIdNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TbxPatientPassword.Text);
            SqlDataReader sqlDataReader=sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                FormSecretaryDetails formSecretaryDetails = new FormSecretaryDetails();
                formSecretaryDetails.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Identity Number Or Password","Error");
            }

            sqLConnectionCls.ConnectDb().Close();
        }
    }
}
