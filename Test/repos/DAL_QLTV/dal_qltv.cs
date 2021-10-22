using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QLTV
{
    public class dal_qltv
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-1EACOMA\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True");
        }
        public DataTable getTable(string sql)
        {
            SqlConnection connect = getConnect();
            connect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql,connect);
            da.Fill(dt);
            connect.Close();
            return dt;

        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection connect = getConnect();
            connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            connect.Dispose();
            connect.Close();
        }
    }
}
