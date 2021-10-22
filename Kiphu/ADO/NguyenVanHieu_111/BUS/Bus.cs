using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenVanHieu.DAL;
namespace NguyenVanHieu.BUS
{
    class Bus
    {
        Dal dal = new Dal();
        public DataTable getSach()
        {
            DataTable da = null;
            String sql = "Select * from Sach ";
            da = dal.getTable(sql);
            return da;
        }
        public void ThemSach(String maSach, String tenSach, int soTrang, String maTheLoai )
        {
            String sql = " insert into Sach values('" + maSach + "',N'" + tenSach + "','" + soTrang + "',N'" + maTheLoai + "')";
            try
            {
                dal.ExcuteNonQuery(sql);
                MessageBox.Show("Thêm thành công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại !");
            }
        }
        public void SuaSach(String maSach, String tenSach, int soTrang, String maTheLoai)
        {
            String sql = "UPDATE Sach set TenSach=N'" + tenSach + "',soTrang='" + soTrang + "',MaTheLoai=N'" + maTheLoai + "' where MaSach='" + maSach + "'";
            try
            {
                dal.ExcuteNonQuery(sql);
                MessageBox.Show("Sửa thành công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại !");
                
            }
        }
        public void xoaSach(String maSach)
        {
            String sql = "delete Sach where maSach='" + maSach + "'";
            try
            {
                dal.ExcuteNonQuery(sql);
                MessageBox.Show("Xóa thành công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!");

            }
        }
        public DataTable Search(String tensach)
        {
            DataTable da = null;
            String sql = "Select * from Sach where tenSach like N'%" + tensach + "%'";
            da = dal.getTable(sql);
            return da;
        }
        public DataTable loadcb()
        {
            DataTable da = null;
            String sql = "select MaTheLoai, TenTheLoai from TheLoai";
            da = dal.getTable(sql);
            return da;
        }
        public DataTable check(String maSach)
        {
            DataTable da = null;
            String sql = "select * from Sach where masach='" + maSach + "' ";
            da = dal.getTable(sql);
            return da;
        }
    }
}
