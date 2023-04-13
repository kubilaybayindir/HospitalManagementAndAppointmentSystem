using MFramework.Services.FakeData;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace HospitalManagementAndAppointmentSystem
{
    public class DataGenerators
    {
        SQLConnectionCls sqlConnectionCls = new SQLConnectionCls();
        public string[] strDepartmentArrays = new string[] { "Cardiologist", "Dermatologists", "Operation", "Hematologist", "Internist", "Neurologist", "Pediatricians", "Urologist", "General Surgeon", "Radiologist" };
        public Random rand = new Random();

        public void DepartmentGenerator()
        {
            for (int i = 0; i < 10; i++)
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Department (DepartmentName) VALUES (@p1)", sqlConnectionCls.ConnectDb());
                sqlCommand.Parameters.AddWithValue("@p1", strDepartmentArrays[rand.Next() % 10]);
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnectionCls.ConnectDb().Close();
            MessageBox.Show("Departments Has Been Generated Successfully.", "Department Data Generator");
        }
        public void DoctorGenerator()
        {
            for (int i = 0; i < 10; i++)
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Doctor(Name,Surname,Department,IdentityNumber,Password) VALUES (@p1,@p2,@p3,@p4,@p5)", sqlConnectionCls.ConnectDb());
                sqlCommand.Parameters.AddWithValue("@p1", NameData.GetFirstName());
                sqlCommand.Parameters.AddWithValue("@p2", NameData.GetSurname());
                sqlCommand.Parameters.AddWithValue("@p3", strDepartmentArrays[rand.Next() % 10]);
                sqlCommand.Parameters.AddWithValue("@p4", ((double)NumberData.GetNumber(100000, 315000) * (double)NumberData.GetNumber(100000, 315000)).ToString());
                sqlCommand.Parameters.AddWithValue("@p5", "123123");
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnectionCls.ConnectDb().Close();
            MessageBox.Show("Doctors Has Been Generated Successfully.", "Doctor Data Generator");
        }
        public void PatientGenerator()
        {
            for (int i = 0; i < 10; i++)
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Patient(Name,Surname,IdentityNumber,Phone,Password,Sex) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", sqlConnectionCls.ConnectDb());
                sqlCommand.Parameters.AddWithValue("@p1", NameData.GetFirstName());
                sqlCommand.Parameters.AddWithValue("@p2", NameData.GetSurname());
                sqlCommand.Parameters.AddWithValue("@p3", ((double)NumberData.GetNumber(100000, 315000) * (double)NumberData.GetNumber(100000, 315000)).ToString());
                sqlCommand.Parameters.AddWithValue("@p4", PhoneNumberData.GetUsPhoneNumber());
                sqlCommand.Parameters.AddWithValue("@p5", "123123");
                sqlCommand.Parameters.AddWithValue("@p6", (i % 2 == 0) ? "Man" : "Woman");
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnectionCls.ConnectDb().Close();
            MessageBox.Show("Patients Has Been Generated Successfully.", "Patient Data Generator");
        }
        public void SecretaryGenerator()
        {
            for (int i = 0; i < 10; i++)
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Secretary(NameSurname,IdentityNumber,Password) VALUES (@p1,@p2,@p3)", sqlConnectionCls.ConnectDb());
                sqlCommand.Parameters.AddWithValue("@p1", NameData.GetFirstName() + NameData.GetSurname());
                sqlCommand.Parameters.AddWithValue("@p2", ((double)NumberData.GetNumber(100000, 315000) * (double)NumberData.GetNumber(100000, 315000)).ToString());
                sqlCommand.Parameters.AddWithValue("@p3", "123123");
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnectionCls.ConnectDb().Close();
            MessageBox.Show("Secretaries Has Been Generated Successfully.", "Secretary Data Generator");
        }
        
    }
}
