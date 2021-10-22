using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAl;
using System.Data;

namespace BUS
{
    public class Bus_ql
    {
        Dal_ql dalql = new Dal_ql();
        public DataTable showhang()
        {
            DataTable dt = null;
            string sql = "Select * from Product ";
            dt = dalql.getTable(sql);
            return dt;
        }
        public void them(string id, string name,   int sl, string nsx, DateTime date)
        {
            String sql = " insert into Product values('" + id + "','" + name + "','" + sl +" ','" + nsx + "','"+date+"')";
            dalql.ExcuteNonQuery(sql);
        }
        public void update(string id, string name,int sl, string nsx, DateTime date)
        {
            string sql = " UPDATE Product set Mahang='" + id + "',Tenhang='" + name + "', Slcon=" + sl + ", Nhasanxuat ='" + nsx + "','" + date + "'where Mahang='" + id + "' ";
            dalql.ExcuteNonQuery(sql);
        }

        public void delete(string id)
        {
            string sql = "Delete Product where Mahang='" + id + "'";
            dalql.ExcuteNonQuery(sql);
        }
        public DataTable checkma(string id)
        {
            DataTable dt = null;
            string sql = "select * from Product where Mahang = '" + id + "'";
            dt = dalql.getTable(sql);
            return dt;
        }

    }
}
