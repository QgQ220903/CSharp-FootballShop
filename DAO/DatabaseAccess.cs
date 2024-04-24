using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class DatabaseAccess
    {
        string ConnectionStr = "Data Source=QGQ\\SQLEXPRESS;Initial Catalog=CuaHangDaBanhDB;Integrated Security=True;";
        protected SqlConnection conn = null;
        protected SqlDataReader reader = null;
        protected SqlCommand command = null;


        public void OpenConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(ConnectionStr);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
