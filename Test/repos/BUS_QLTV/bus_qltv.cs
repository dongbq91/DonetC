using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_QLTV;
namespace BUS_QLTV
{
    public class bus_qltv
    {
        dal_qltv dal = new dal_qltv();
        public DataTable showSach()
        {
            DataTable dt = new DataTable();
            string sql = "select*from Sach";
            dt = dal.getTable(sql);
            return dt;
        }
        public DataTable laydulieucb()
        {
            DataTable dt = new DataTable();
            string sql = "select matheloai,tentheloai from theloai";
            dt = dal.getTable(sql);
            return dt;
        }
        public void insert(string masach,string tensach,int sotrang,string theloai)
        {
            string sql = "insert into sach values('" + masach + "','" + tensach + "','" + sotrang + "','" + theloai + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void delete(string masach)
        {
            string sql = "delete from sach where masach='" + masach + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void update(string masach,string tensach,int sotrang,string theloai)
        {
            string sql="update sach set tensach='"+tensach+"',sotrang='"+sotrang+"',matheloai='"+theloai+"' where masach='" + masach + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable KiemTra(string masach)
        {
            string sql = "select *from sach where masach='" + masach + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}
