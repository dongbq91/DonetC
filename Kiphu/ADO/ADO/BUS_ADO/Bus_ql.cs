using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_ADO;

namespace BUS_ADO
{
    public class Bus_ql
    {
        Dal_ql dalql = new Dal_ql();
        public DataTable showql()
        {
            String sql = "Select * from Employees";
            DataTable dt = new DataTable();
            dt = dalql.getTable(sql);
            return dt;
        }
        public void themnv(int EID , int DID, string Ten, string sex, string ngay, string diachi)
        {
            string sql = "insert into Employees values ('" + EID + "','" + DID + "', 'N"+ Ten + "', 'N" +sex + "', 'N" + ngay + "', , 'N" + diachi + "')";
            dalql.ExcuteNonQuery(sql);
        }
        public void updatenv(int  EID, int DID, string Ten, string sex, string ngay, string diachi)
        {
            string sql = " update Employees set EmployeeID='" + EID + "',DepartmentID='" + DID + "', fullName='N" + Ten + "', Gender='N" + sex + "', Birthday='N" + ngay + "', , Address='N" + diachi + "')";
            dalql.ExcuteNonQuery(sql);
        }

        public void deletebv (int EID)
        {
            string sql = "Delete Employees where EmployeeID='" + EID + "'";
            dalql.ExcuteNonQuery(sql);
        }

    }
}
