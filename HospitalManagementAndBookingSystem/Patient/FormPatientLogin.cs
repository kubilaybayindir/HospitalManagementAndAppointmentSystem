using HospitalManagementAndAppointmentSystem.Patient;
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
    public partial class FormPatientLogin : Form
    {
        public FormPatientLogin()
        {
            InitializeComponent();
        }

        private void FormPatientLogin_Load(object sender, EventArgs e)
        {

        }
        SQLConnectionCls sqlConnectionCls = new SQLConnectionCls();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPatientRegister formPatientRegister = new FormPatientRegister();
            formPatientRegister.Show();
        }

        private void BtPatientLogin_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Patient WHERE IdentityNumber =@p1  And Password = @p2 ", sqlConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@p1", MTbxPatientLgnIdNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TbxPatientLgnPassword.Text);
            //sqlCommand.ExecuteNonQuery();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                FormPatientDetails formPatientDetails = new FormPatientDetails();
                formPatientDetails.IdentityNumber =MTbxPatientLgnIdNumber.Text;
                formPatientDetails.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Identity Number Or Password", "Login Error");
            }
            sqlConnectionCls.ConnectDb().Close();
        }
    }
}
