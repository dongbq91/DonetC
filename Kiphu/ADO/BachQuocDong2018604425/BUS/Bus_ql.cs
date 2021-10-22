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
            string sql = "Select *  from Khachhang ";
            dt = dalql.getTable(sql);
            return dt;
        }
        public void them(string id, string name , int cmt, int phong ,string gtinh , DateTime date)
        {
            String sql = " insert into Khachhang values('" + id + "','" + name + "','" + cmt + " ','" + phong + "','" + gtinh + "','" + date + "')";

            dalql.ExcuteNonQuery(sql);

        }
        public void update(string id, string name, int cmt, int phong, string gtinh, DateTime date)
        {
            String sql = " UPDATE Khachhang set Makhachhang='" + id + "',Tenkhachhang='" + name + "', Socmnd ='" + cmt + "', Sophong ='" + phong + "',gioitinh ='" + gtinh + "',Ngaycheckin ='" + date + "' where Makhachhang ='" + id + "' ";

            dalql.ExcuteNonQuery(sql);

        }
        public void delete(string id)
        {
            string sql = "Delete Khachhang where Makhachhang='" + id + "'";
            dalql.ExcuteNonQuery(sql);
        }
        public DataTable checkma(string id)
        {
            DataTable dt = null;
            string sql = "select * from Khachhang where Makhachhang = '" + id + "' ";
            dt = dalql.getTable(sql);
            return dt;
        }
    }
}
