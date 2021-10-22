using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class Bussp
    {
        Dalsp dalsp = new Dalsp();
        public DataTable showql()
        {
            String sql = "Select * from SanPham";
            DataTable dt = new DataTable();
            dt = dalsp.getTable(sql);
            return dt;
        }
        public void them(string maSP, string tensp, string mau, int slt, int giat, string mahangt)
        {
            string sql = "insert into SanPham values ('" + maSP + "','" + tensp + "', '" + mau + "', '" + slt + "', '" + giat + "', '" + mahangt + "')";
            dalsp.ExcuteNonQuery(sql);

        }
        public void update(string maSP, string tensp, string mau, int slt, int giat, string mahangt)
        {
            string sql = " UPDATE SanPham set MaSP='" + maSP + "',TenSP='" + tensp + "', Mausac='" + mau + "', Soluong='" + slt + "', giaban='" + giat + "', MaHang='" + mahangt + "'where MaSP='"+maSP+"' ";
            dalsp.ExcuteNonQuery(sql);
        }

        public void delete(string maSP)
        {
            string sql = "Delete SanPham where MaSP='" + maSP + "'";
            dalsp.ExcuteNonQuery(sql);
        }
        public DataTable checkma( string MaSP)
        {
            DataTable dt = null;
            string sql = "select * from SanPham where MaSP = '" + MaSP + "'";
            dt = dalsp.getTable(sql);
            return dt;
        }
        public string selectpb(string mahang)
        {
            
            string tenhang;
            string sql = "select * from HangSX where Tenhang = '" + mahang + "'";
            tenhang = dalsp.ExcuteScalar(sql);
            return tenhang;
        }
    }
}
