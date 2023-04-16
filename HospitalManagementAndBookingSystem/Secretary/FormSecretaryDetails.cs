using HospitalManagementAndAppointmentSystem.Doctor;
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

namespace HospitalManagementAndAppointmentSystem.Secretary
{
    public partial class FormSecretaryDetails : Form
    {
        public FormSecretaryDetails()
        {
            InitializeComponent();
        }
        public string SecretaryIdentityNumber { get; set; }
        SQLConnectionCls sqlConnectionCls =new SQLConnectionCls();
        private void FormSecretaryDetails_Load(object sender, EventArgs e)
        {
            //Get Name-Surname From Secretary Db.
            LblSecIdentityNumber.Text = SecretaryIdentityNumber;
            SqlCommand sqlCommand = new SqlCommand("SELECT NameSurname FROM Secretary WHERE IdentityNumber=@p1", sqlConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@p1",LblSecIdentityNumber.Text);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                LblSecNameSurname.Text = sqlDataReader[0].ToString();
            }
            sqlConnectionCls.ConnectDb().Close();

            //Import Department Datas To DataGridView

            DataTable datatable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT DepartmentName FROM Department",sqlConnectionCls.ConnectDb());
            sqlDataAdapter.Fill(datatable);
            DgvDepartments.DataSource = datatable;

            //Import Doctor Datas To DataGridView

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT (Name + ' ' + Surname) AS 'Doctors' FROM Doctor", sqlConnectionCls.ConnectDb());
            da.Fill(dt);
            DgvDoctors.DataSource = dt;

            //Transfer Department Name Datas To Department Combobox
            SqlCommand sqlCbxDepCommand = new SqlCommand("SELECT DepartmentName FROM Department", sqlConnectionCls.ConnectDb());
            SqlDataReader sqlCbxDepDataReader = sqlCbxDepCommand.ExecuteReader();
            while (sqlCbxDepDataReader.Read())
            {
                CbxDepartment.Items.Add( sqlCbxDepDataReader[0].ToString());
            }
        }
        private void BtAppointmentSave_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Appointment (Date,Hour,Department,Doctor) VALUES(@r1,@r2,@r3,@r4)", sqlConnectionCls.ConnectDb());
            sqlCommand.Parameters.AddWithValue("@r1", MTxtDate.Text);
            sqlCommand.Parameters.AddWithValue("@r2", MTxtHour.Text);
            sqlCommand.Parameters.AddWithValue("@r3", CbxDepartment.Text);
            sqlCommand.Parameters.AddWithValue("@r4", CbxDoctor.Text);
            
            sqlCommand.ExecuteNonQuery();
            sqlConnectionCls.ConnectDb().Close();

            MessageBox.Show("Appointment Was Added Successfully", "Appointment Done");
        }

        private void CbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Transfer Doctor Name And Surname Datas To Doctor Combobox
            CbxDoctor.Items.Clear();
            SqlCommand sqlCbxDocCommand = new SqlCommand("SELECT (Name + ' ' + Surname) AS 'Doctors'FROM Doctor WHERE Department=@p1", sqlConnectionCls.ConnectDb());
            sqlCbxDocCommand.Parameters.AddWithValue("@p1", CbxDepartment.Text);

            SqlDataReader sqlCbxDocDataReader = sqlCbxDocCommand.ExecuteReader();
            while (sqlCbxDocDataReader.Read())
            {
                CbxDoctor.Items.Add(sqlCbxDocDataReader[0].ToString());
            }
            sqlConnectionCls.ConnectDb().Close();
        }
        private void BtCreateAnnouncement_Click(object sender, EventArgs e)
        {
            if (RTbxSecAnnouncements.Text != "")
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO  Announcement (Context) VALUES (@p1)", sqlConnectionCls.ConnectDb());
                sqlCommand.Parameters.AddWithValue("@p1", RTbxSecAnnouncements.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnectionCls.ConnectDb().Close();

                MessageBox.Show("Announcement Was Added Successfully", "Announcement Done");
            }
        }

        private void BtDoctorPanel_Click(object sender, EventArgs e)
        {
            FormDoctorPanel formDoctorPanel = new FormDoctorPanel();
            formDoctorPanel.Show();
            this.Hide();
        }

        private void BtDepartmentPanel_Click(object sender, EventArgs e)
        {
            FormDepartmentPanel formDepartmentPanel = new FormDepartmentPanel();
            formDepartmentPanel.Show();
            this.Hide();
        }

        private void BtAnnouncementList_Click(object sender, EventArgs e)
        {
            FormAnnouncementList formAnnouncementList = new FormAnnouncementList();
            formAnnouncementList.Show();
            this.Hide();
        }
    }
}
