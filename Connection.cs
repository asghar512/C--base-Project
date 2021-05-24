using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    class Connection
    {
        string ConnectionString = @"Data Source=.;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
        SqlConnection conn = null;

        public Connection()
        {
            conn = new SqlConnection(ConnectionString);
        }

        public SqlConnection Connect()
        {
            if (conn != null)
            {
                conn.Open();
            }
            return conn;
        }
        public SqlConnection Close()
        {
            conn.Close();
            return conn;
        }
    }
}
