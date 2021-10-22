using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dal_T3
{
    public class Dal
    {
        public SqlConnection getconnect()
        {
            return new SqlConnection(@"Data Source=DONGBQ-PC;Initial Catalog=QLsach;Integrated Security=True");
        }
        public DataTable GetTable(string sql)
        {
            SqlConnection connect = getconnect();
            connect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            connect.Close();
            return dt;
        }
        public void Excute (string sql)
        {
            SqlConnection connect = getconnect();
            connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            connect.Dispose();
            connect.Close();
        }
    }
}
