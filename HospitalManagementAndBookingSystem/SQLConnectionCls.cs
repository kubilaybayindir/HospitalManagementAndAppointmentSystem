using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementAndAppointmentSystem
{
    public class SQLConnectionCls
    {
        public SqlConnection connect()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HospitalManagementDB;Integrated Security=True");
            sqlConnection.Open();


            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                
            }
            else
            {
                MessageBox.Show("Error", "Error");
            }
            return sqlConnection;
        }
    }
}
