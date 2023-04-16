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
    public partial class FormDoctorPanel : Form
    {
        public FormDoctorPanel()
        {
            InitializeComponent();
        }
        SQLConnectionCls sqlConnectionCls = new SQLConnectionCls();
        private void FormDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Doctor", sqlConnectionCls.ConnectDb());
            sqlDataAdapter.Fill(dataTable);
            DgvDoctors.DataSource = dataTable;


            //Transfer Department Name Datas To Department Combobox
            SqlCommand sqlCbxDepCommand = new SqlCommand("SELECT DepartmentName FROM Department", sqlConnectionCls.ConnectDb());
            SqlDataReader sqlCbxDepDataReader = sqlCbxDepCommand.ExecuteReader();
            while (sqlCbxDepDataReader.Read())
            {
                CbxDocDepartmentPnl.Items.Add(sqlCbxDepDataReader[0].ToString());
            }
        }

        private void BtDocInsertPnl_Click(object sender, EventArgs e)
        {
            if (TxtDocNamePnl.Text != "" && TxtDocSurnamePnl.Text != "" && CbxDocDepartmentPnl.Text != "" && MTxtDocIdentityNumberPnl.Text != "" && TxtDocPasswordPnl.Text != "" )
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO  Doctor (Name,Surname,Department,IdentityNumber,Password) VALUES (@p1,@p2,@p3,@p4,@p5)", sqlConnectionCls.ConnectDb());
                sqlCommand.Parameters.AddWithValue("@p1", TxtDocNamePnl.Text);
                sqlCommand.Parameters.AddWithValue("@p2", TxtDocSurnamePnl.Text);
                sqlCommand.Parameters.AddWithValue("@p3", CbxDocDepartmentPnl.Text);
                sqlCommand.Parameters.AddWithValue("@p4", MTxtDocIdentityNumberPnl.Text);
                sqlCommand.Parameters.AddWithValue("@p5", TxtDocPasswordPnl.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnectionCls.ConnectDb().Close();

                MessageBox.Show("Doctor Was Added Successfully", "Doctor Done");
            }
            else
            {
                MessageBox.Show("Plese Fill in the blanks ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void BtDocDeletePnl_Click(object sender, EventArgs e)
        {
            if (MTxtDocIdentityNumberPnl.Text != "")
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Doctor WHERE IdentityNumber=@p1", sqlConnectionCls.ConnectDb());
                sqlCommand.Parameters.AddWithValue("@p1", MTxtDocIdentityNumberPnl.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnectionCls.ConnectDb().Close();

                MessageBox.Show("Doctor Deleting Was Added Successfully", "Doctor Delete Done");
            }
            else
            {
                MessageBox.Show("Plese Fill in the Identity Number ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtDocUpdatePnl_Click(object sender, EventArgs e)
        {
            if (TxtDocNamePnl.Text != "" && TxtDocSurnamePnl.Text != "" && CbxDocDepartmentPnl.Text != "" && MTxtDocIdentityNumberPnl.Text != "" && TxtDocPasswordPnl.Text != "")
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Doctor SET Name=@p1,SurName=@p2,Department=@p3,Password=@p4 WHERE IdentityNumber=@p5", sqlConnectionCls.ConnectDb());
                sqlCommand.Parameters.AddWithValue("@p1", TxtDocNamePnl.Text);
                sqlCommand.Parameters.AddWithValue("@p2", TxtDocSurnamePnl.Text);
                sqlCommand.Parameters.AddWithValue("@p3", CbxDocDepartmentPnl.Text);
                sqlCommand.Parameters.AddWithValue("@p4", TxtDocPasswordPnl.Text);
                sqlCommand.Parameters.AddWithValue("@p5", MTxtDocIdentityNumberPnl.Text); 
                sqlCommand.ExecuteNonQuery();
                sqlConnectionCls.ConnectDb().Close();

                MessageBox.Show("Doctor Was Added Successfully", "Doctor Done");
            }
            else
            {
                MessageBox.Show("Plese Fill in the blanks ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosenRow = DgvDoctors.SelectedCells[0].RowIndex;
            TxtDocNamePnl.Text = DgvDoctors.Rows[chosenRow].Cells[1].Value.ToString();
            TxtDocSurnamePnl.Text = DgvDoctors.Rows[chosenRow].Cells[2].Value.ToString();
            CbxDocDepartmentPnl.Text = DgvDoctors.Rows[chosenRow].Cells[3].Value.ToString();
            MTxtDocIdentityNumberPnl.Text = DgvDoctors.Rows[chosenRow].Cells[4].Value.ToString();
            TxtDocPasswordPnl.Text = DgvDoctors.Rows[chosenRow].Cells[5].Value.ToString();
        }
    }
}
