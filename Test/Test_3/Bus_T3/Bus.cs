using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dal_T3;

namespace Bus_T3
{
    public class Bus
    {
        Dal dal = new Dal();
        public void  xoa(string masach)
        {
            string sql = "delete from sach where masach = '" + masach + "'";
            dal.Excute(sql);
        }
        public void them (string masach , string tensach , int sotrang , string matheloai)
        {
            string sql = " insert into sach values ('" + masach + "','" + tensach + "','" + sotrang + "','" + matheloai + "')";
            dal.Excute(sql);
        }
        public DataTable kiemtra(string masach)
        {
            string sql = "select*from sach where masach='" + masach + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
