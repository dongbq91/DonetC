using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_ADO
{
    public class Dal_ql
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DONGBQ-PC\DONGBQ;Initial Catalog=QLNS;Integrated Security=True");
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
    }
}
