using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dal_T4
{
    public class Dal_cl
    {
        public SqlConnection getconnect()
        {
            return new SqlConnection ("@Data Source=DONGBQ-PC;Initial Catalog=QLsach;Integrated Security=True");
        }
        public DataTable GetTable(string sql)
        {
            SqlConnection conn = getconnect();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void Excute(string sql)
        {
            SqlConnection conn = getconnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
