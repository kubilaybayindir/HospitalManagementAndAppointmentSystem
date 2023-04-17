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
    public partial class FormDoctorDetails : Form
    {
        public FormDoctorDetails()
        {
            InitializeComponent();
        }
        public string DoctorIdentityNumber;
        SQLConnectionCls sqlConnectionCls = new SQLConnectionCls();
        private void FormDoctorDetails_Load(object sender, EventArgs e)
        {
            LblDoctorIdentityNumber.Text = DoctorIdentityNumber;

            //Get Name-Surname
            SqlCommand sqlCommand = new SqlCommand("SELECT Name,Surname FROM Doctor WHERE IdentityNumber = @p1", sqlConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@p1", LblDoctorIdentityNumber.Text);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LblNameSurname.Text = sqlDataReader[0] + " " + sqlDataReader[1];
            }
            sqlConnectionCls.ConnectDb().Close();

            //Appointments

            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Appointment WHERE Doctor ='" +LblNameSurname.Text + "'",sqlConnectionCls.ConnectDb());
            sqlDataAdapter.Fill(dt);
            DgvAppointmentHistory.DataSource=dt;
        }

        public void BtDoctorEditDetails_Click(object sender, EventArgs e)
        {
            FormDoctorEditDetails formDoctorEditDetails = new FormDoctorEditDetails();
            formDoctorEditDetails.DoctorIdentityNumber = DoctorIdentityNumber;
            formDoctorEditDetails.Show();
        }

        private void BtAnnouncements_Click(object sender, EventArgs e)
        {
            FormAnnouncementList formAnnouncementList = new FormAnnouncementList();
            formAnnouncementList.Show();
        }

        private void DgvAppointmentHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ChosenRow = DgvAppointmentHistory.SelectedCells[0].RowIndex;
            RTbxDisease.Text = DgvAppointmentHistory.Rows[ChosenRow].Cells[7].Value.ToString();
        }
    }
}
