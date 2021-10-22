using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal_T4;

namespace Bus_T4
{
    public class Bus_cl
    {
        Dal_cl dal = new Dal_cl();
        public DataTable kiemtra(string masach)
        {
            string sql = "Select * from sach where masach='" + masach + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void xoa(string masach)
        {
            string sql = "Delete from sach where masach = '"+masach+"'";
            dal.Excute(sql);
        }
        public void them(string masach , string tensach , int sotrang , string matheloai)
        {
            string sql = " insert into sach values('" + masach + "','" + tensach + "','" + sotrang + "','" + matheloai + "')";
            dal.Excute(sql);
        }
    }
}
