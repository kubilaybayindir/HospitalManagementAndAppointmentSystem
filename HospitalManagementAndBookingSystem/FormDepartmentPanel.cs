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
    public partial class FormDepartmentPanel : Form
    {
        public FormDepartmentPanel()
        {
            InitializeComponent();
        }
        SQLConnectionCls sqlConnectionCls =new SQLConnectionCls();
        private void FormDepartmentPanel_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Department", sqlConnectionCls.ConnectDb());
            sqlDataAdapter.Fill(dataTable);
            DgVDepartments.DataSource = dataTable;
        }

        private void DgVDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosenRow = DgVDepartments.SelectedCells[0].RowIndex;
            TxtDepartmentIdPnl.Text = DgVDepartments.Rows[chosenRow].Cells[0].Value.ToString();
            TxtDepartmentNamePnl.Text = DgVDepartments.Rows[chosenRow].Cells[1].Value.ToString();
        }

        private void BtDepartmentInsertPnl_Click(object sender, EventArgs e)
        {
            
            if (TxtDepartmentNamePnl.Text != "")
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Department(DepartmentName) VALUES(@p1) ", sqlConnectionCls.ConnectDb());
                sqlCommand.Parameters.AddWithValue("@p1", TxtDepartmentNamePnl.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnectionCls.ConnectDb().Close();

                MessageBox.Show("Department Was Added Successfully", "Department Done");
            }
            else
            {
                MessageBox.Show("Plese Fill in the blanks ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void BtDepartmentDeletePnl_Click(object sender, EventArgs e)
        {
            if (TxtDepartmentIdPnl.Text != "" && TxtDepartmentNamePnl.Text != "")
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Department WHERE Id=@p1", sqlConnectionCls.ConnectDb());
                sqlCommand.Parameters.AddWithValue("@p1", TxtDepartmentIdPnl.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnectionCls.ConnectDb().Close();

                MessageBox.Show("Department Deleting Was Added Successfully", "Department Deleting Done");
            }
            else
            {
                MessageBox.Show("Plese Fill in the Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtDepartmentUpdatePnl_Click(object sender, EventArgs e)
        {
            if (TxtDepartmentIdPnl.Text != "" && TxtDepartmentNamePnl.Text != "")
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Department SET DepartmentName=@p1 WHERE Id=@p2", sqlConnectionCls.ConnectDb());
                sqlCommand.Parameters.AddWithValue("@p1", TxtDepartmentNamePnl.Text);
                sqlCommand.Parameters.AddWithValue("@p2", TxtDepartmentIdPnl.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnectionCls.ConnectDb().Close();

                MessageBox.Show("Department  Was Updated Successfully", "Department Updating Done");
            }
            else
            {
                MessageBox.Show("Plese Fill in the blanks ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
