using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MisPis_WFA
{
    internal class database
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-8AH9BLU;Initial Catalog=mispis_project;Integrated Security=True");
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=.;Initial Catalog=mispis_project;Integrated Security=True");
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

    }
}

