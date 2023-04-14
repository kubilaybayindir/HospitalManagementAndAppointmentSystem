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

namespace HospitalManagementAndAppointmentSystem.Patient
{
    public partial class FormPatientEditDetails : Form
    {
        public FormPatientEditDetails()
        {
            InitializeComponent();
        }
        SQLConnectionCls sqlConnectionCls = new SQLConnectionCls();
        public string patientIdentityNumber { get; set; }


        private void FormPatientEditDetails_Load(object sender, EventArgs e)
        {
            MTxtIdentityNumber.Text = patientIdentityNumber;
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Patient WHERE IdentityNumber=@p1", sqlConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@p1", MTxtIdentityNumber.Text);
            SqlDataReader sqlPatientDataReader=sqlCommand.ExecuteReader();
            if (sqlPatientDataReader.HasRows)
            {
                TxtName.Text = sqlPatientDataReader.ToString();
            }
            while (sqlPatientDataReader.Read())
            {
                TxtName.Text = sqlPatientDataReader[1].ToString();
                TxtSurname.Text = sqlPatientDataReader[2].ToString();
                //MTxtIdentityNumber.Text = sqlPatientDataReader[3].ToString(); We Already Know
                MTxtPhone.Text = sqlPatientDataReader[4].ToString();
                TxtPassword.Text = sqlPatientDataReader[5].ToString();
                CbxSex.Text = sqlPatientDataReader[6].ToString();
            }

            sqlConnectionCls.ConnectDb().Close();
        }

        private void BtPatientUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Patient  SET Name=@p1,Surname=@p2,Phone=@p3,Password=@p4,Sex=@p5 WHERE IdentityNumber=@p6", sqlConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@p1", TxtName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtSurname.Text);
            sqlCommand.Parameters.AddWithValue("@p3", MTxtPhone.Text);
            sqlCommand.Parameters.AddWithValue("@p4", TxtPassword.Text);
            sqlCommand.Parameters.AddWithValue("@p5", CbxSex.Text);
            sqlCommand.Parameters.AddWithValue("@p6", MTxtIdentityNumber.Text);

            sqlCommand.ExecuteNonQuery();

            sqlConnectionCls.ConnectDb().Close();
            MessageBox.Show("Patient Data Has Been Updated","Patient Update");
        }
    }
}
