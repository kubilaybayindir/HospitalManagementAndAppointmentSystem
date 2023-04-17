using HospitalManagementAndAppointmentSystem.Doctor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementAndAppointmentSystem
{
    public partial class FormDoctorLogin : Form
    {
        public FormDoctorLogin()
        {
            InitializeComponent();
        }
        SQLConnectionCls sqlConnectionCls = new SQLConnectionCls();
        public void BtDocLogin_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Doctor WHERE IdentityNumber = @p1 AND Password = @p2", sqlConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@p1", MTbxDoctorIdNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TbxDoctorPassword.Text);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                FormDoctorDetails formDoctorDetails = new FormDoctorDetails();
                formDoctorDetails.DoctorIdentityNumber = MTbxDoctorIdNumber.Text;
                formDoctorDetails.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Identity Number Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
