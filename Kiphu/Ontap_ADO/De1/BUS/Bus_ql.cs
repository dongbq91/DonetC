using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class Bus_ql
    {
        Dal_ql dalql = new Dal_ql();
        public DataTable show()
        {
            DataTable dt = null;
            string sql = "Select *  from Hanghoa ";
            dt = dalql.getTable(sql);
            return dt;
        }
        public void them(string id, string name, string luuy, DateTime date , int sl)
        {
            String sql = " insert into Hanghoa values('" + id + "','" + name + "','" + luuy + " ','" + date + "','" + sl + "')";

            dalql.ExcuteNonQuery(sql);

        }
        public void update(string id, string name, string luuy, DateTime date, int sl)
        {
            String sql = " UPDATE Hanghoa set MaHang='" + id + "',TenHang='" + name + "', LuuY ='" + luuy + "',NgaySanXuat ='" + date + "' ,SoLuong='"+sl+ "'  where MaHang ='" + id + "' ";

            dalql.ExcuteNonQuery(sql);

        }
        public void delete(string id)
        {
            string sql = "Delete from Hanghoa where MaHang ='" + id + "'";
            dalql.ExcuteNonQuery(sql);
        }
        public DataTable checkma(string id)
        {
            DataTable dt = null;
            string sql = "select * from Hanghoa where MaHang = '" + id + "' ";
            dt = dalql.getTable(sql);
            return dt;
        }
    }
}
