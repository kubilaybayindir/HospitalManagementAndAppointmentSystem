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
    public partial class FormPatientRegister : Form
    {
        public FormPatientRegister()
        {
            InitializeComponent();
        }

        SQLConnectionCls sqlConnectionCls = new SQLConnectionCls();
        private void BtRegister_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Patient(Name,Surname,IdentityNumber,Phone,Password,Sex) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", sqlConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@p1",TxtPatientRegName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtPatientRegSurname.Text);
            sqlCommand.Parameters.AddWithValue("@p3", MTxtPatientRegIdentityNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p4", MTxtPatientRegPhone.Text);
            sqlCommand.Parameters.AddWithValue("@p5", TxtPatientRegPassword.Text);
            sqlCommand.Parameters.AddWithValue("@p6", CbxPatientRegSex.Text);

            sqlCommand.ExecuteNonQuery();
            sqlConnectionCls.ConnectDb().Close();

            MessageBox.Show("Your Registration Has Been Completed Successfully.", "Registration");
            
        }
    }
}
