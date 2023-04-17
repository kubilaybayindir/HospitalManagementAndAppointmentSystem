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

namespace HospitalManagementAndAppointmentSystem.Doctor
{
    public partial class FormDoctorEditDetails : Form
    {
        public FormDoctorEditDetails()
        {
            InitializeComponent();
        }
        public string DoctorIdentityNumber;
        SQLConnectionCls sqlConnectionCls = new SQLConnectionCls();

        public void FormDoctorEditDetails_Load(object sender, EventArgs e)
        {
            
            SqlCommand sqlDEDCommand = new SqlCommand("SELECT * FROM Doctor WHERE IdentityNumber = " + DoctorIdentityNumber,sqlConnectionCls.ConnectDb());

            SqlDataReader sqlDataReader = sqlDEDCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                TxtDocName.Text = sqlDataReader[1].ToString();
                TxtDocSurname.Text = sqlDataReader[2].ToString();
                MTxtDocIdentityNumber.Text = sqlDataReader[4].ToString();
                CbxDocDepartment.Text = sqlDataReader[3].ToString();
                TxtDocPassword.Text = sqlDataReader[5].ToString();
            }
        }
        private void BtDocUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Doctor SET Name=@p1,SurName=@p2,Department=@p3,Password=@p4 WHERE IdentityNumber=@p5", sqlConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@p1", TxtDocName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtDocSurname.Text);
            sqlCommand.Parameters.AddWithValue("@p3", CbxDocDepartment.Text);
            sqlCommand.Parameters.AddWithValue("@p4", TxtDocPassword.Text);
            sqlCommand.Parameters.AddWithValue("@p5", MTxtDocIdentityNumber.Text);
            
            

            sqlCommand.ExecuteNonQuery();
            sqlConnectionCls.ConnectDb().Close();

            MessageBox.Show("Doctor Datas Was Updated Successfully", "Update Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
