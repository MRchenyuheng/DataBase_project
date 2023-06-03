using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Store
{
    internal class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=DESKTOP-OERENOG\MSSQLSERVER1;Initial Catalog=easystores;Integrated Security=True";
            sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;

        }
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();
        }
    }
}
