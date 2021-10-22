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
            string sql = "Select Mahang, Tenhang , Dongia, Tenloai  from Hang inner join LoaiHang on Hang.Maloai = LoaiHang.Maloai; ";
            dt = dalql.getTable(sql);
            return dt;
        }
        public DataTable loadcb()
        {
            DataTable dt = null;
            string sql = "select Maloai ,Tenloai from LoaiHang ";
            dt = dalql.getTable(sql);
            return dt;
        }
        public void them(string id, string name, string gia, string loai)
        {
            String sql = " insert into Hang values('" + id + "','" + name + "','" + gia + " ','" + loai + "')";

            dalql.ExcuteNonQuery(sql);

        }
        
        public DataTable checkma(string id)
        {
            DataTable dt = null;
            string sql = "select * from Hang where Mahang = '" + id + "' ";
            dt = dalql.getTable(sql);
            return dt;
        }
        public DataTable seach(String name)
        {
            DataTable dt = null;
            string sql = "Select Mahang, Tenhang , Dongia, LoaiHang.Tenloai  from Hang inner join LoaiHang on Hang.Maloai = LoaiHang.Maloai where Maloai like N'%" + name + "'";
            dt = dalql.getTable(sql);
            return dt;
        }
    }
}
