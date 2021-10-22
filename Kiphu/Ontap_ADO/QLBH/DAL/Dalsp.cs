using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Dalsp
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DONGBQ-PC\DONGBQ;Initial Catalog=QLBHADO;Integrated Security=True");
        }
        public DataTable getTable(string strsql)
        {
            SqlConnection conn = getConnect();
            SqlDataAdapter da = new SqlDataAdapter(strsql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void ExcuteNonQuery(string strsql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strsql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
        public String ExcuteScalar(String sql)
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            String kq = cmd.ExecuteScalar().ToString();
            conn.Close();
            return kq;
        }
    }
}
