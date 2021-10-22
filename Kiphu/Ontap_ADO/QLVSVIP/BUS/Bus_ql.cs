using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class Bus_ql
    {
        Dal_ql dalql = new Dal_ql();

        public DataTable show()
        {
            DataTable dt = null;
            string sql = "Select Masv, Tensv ,Ngaysinh, Diem, gioitinh , Tenkhoa  from Sinhvien inner join Khoa on Khoa.Makhoa = Sinhvien.Makhoa; ";
            dt = dalql.getTable(sql);
            return dt;
        }
        public DataTable loadcb()
        {
            DataTable dt = null;
            string sql = "select Makhoa ,Tenkhoa from Khoa ";
            dt = dalql.getTable(sql);
            return dt;
        }
        public void them(string id, string name, DateTime date, int diem, string mak, string sex)
        {
            String sql = " insert into Sinhvien values('" + id + "','" + name + "','" + date + " ','" + diem + "','" + mak + "','" + sex + "')";

            dalql.ExcuteNonQuery(sql);

        }
        public void update(string id, string name, DateTime date, int diem, string mak, string sex)
        {
            string sql = " UPDATE Sinhvien set Masv='" + id + "',Tensv='" + name + "',Ngaysinh='" + date + "', Diem ='" + diem + "',Makhoa='" + mak + "',Gioitinh='" + sex + "' where Masv='" + id + "' ";
            dalql.ExcuteNonQuery(sql);
        }

        public void delete(string id)
        {
            string sql = "Delete Sinhvien where Masv='" + id + "'";
            dalql.ExcuteNonQuery(sql);
        }
        public DataTable checkma(string id)
        {
            DataTable dt = null;
            string sql = "select * from Sinhvien where Masv = '" + id + "' ";
            dt = dalql.getTable(sql);
            return dt;
        }
        public DataTable seach(String name)
        {
            DataTable dt = null;
            string sql = "select * from Sinhvien where Tensv like N'%" + name + "'";
            dt = dalql.getTable(sql);
            return dt;
        }

      
    }
}
