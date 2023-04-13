using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MFramework.Services.FakeData;
using static HospitalManagementAndAppointmentSystem.DataGenerators;

namespace HospitalManagementAndAppointmentSystem.Patient
{
    public partial class FormPatientDetails : Form
    {
        public FormPatientDetails()
        {
            InitializeComponent();
        }

        public string IdentityNumber { get; set; }
        SQLConnectionCls sqlConnectionCls =new SQLConnectionCls();
        DataGenerators DataGenerators = new DataGenerators();
        private void FormPatientDetails_Load(object sender, EventArgs e)
        {
            
            LblPatientIdentityNumber.Text = IdentityNumber;
            
            //Get Name-Surname
            SqlCommand sqlCommandNS = new SqlCommand("SELECT Name,Surname FROM Patient WHERE IdentityNumber = @p1", sqlConnectionCls.ConnectDb());
            sqlCommandNS.Parameters.AddWithValue("@p1",LblPatientIdentityNumber.Text);

            SqlDataReader sqlDataReader = sqlCommandNS.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LblPatientNameSurname.Text = sqlDataReader[0] + " " + sqlDataReader[1];
            }

            sqlConnectionCls.ConnectDb().Close();

            //Appointment History 
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter=new SqlDataAdapter("SELECT * FROM Appointment WHERE PatinetIdentityNumber=" + IdentityNumber,sqlConnectionCls.ConnectDb());
            sqlDataAdapter.Fill(dataTable);
            DgvAppointmentHistory.DataSource=dataTable;

            //Get Departments
            SqlCommand sqlCommandDep = new SqlCommand("SELECT DepartmentName FROM Department", sqlConnectionCls.ConnectDb());
            SqlDataReader sqlDataReaderDep = sqlCommandDep.ExecuteReader();
            while (sqlDataReaderDep.Read())
            {
                CbxPatientDepartment.Items.Add(sqlDataReaderDep[0]);
            }
            sqlConnectionCls.ConnectDb().Close();

        }

        public void LblGeneratePatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataGenerators.DepartmentGenerator();
        }

        private void CbxPatientDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT Name,Surname FROM Doctor WHERE Department = @p1", sqlConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@p1",CbxPatientDepartment.Text);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                CbxPatientDoctor.Items.Add(sqlDataReader[0]+ " " + sqlDataReader[1]);   
            }
            sqlConnectionCls.ConnectDb().Close();
        }

        private void CbxPatientDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable   =new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Appointment WHERE Department ='" + CbxPatientDepartment.Text + "'", sqlConnectionCls.ConnectDb());

            SqlCommand sqlCommand = new SqlCommand("SELECT Name,Surname FROM Doctor WHERE Department = @p1", sqlConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@p1", CbxPatientDepartment.Text);

            sqlDataAdapter.Fill(dataTable);

            DgvActiveAppointment.DataSource = dataTable;

            //sqlConnectionCls.ConnectDb().Close();
        }

        private void LLblEditDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPatientEditDetails formEditDetails = new FormPatientEditDetails();
            //formEditDetails.
            formEditDetails.Show();
        }
    }
}
