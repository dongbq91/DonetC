using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_ADO;

namespace ADO
{
    public partial class form1 : Form
    {
        Bus_ql busql = new Bus_ql();
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.qLNSDataSet1.Employees);
            // TODO: This line of code loads data into the 'qLNSDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.qLNSDataSet.Departments);
            txtMaNV.Focus();
            radNam.Checked = true;
            radNu.Checked = false;
            DataTable dt = new DataTable();
            dt = busql.showql();
            dgvnhanvien.DataSource = dt;
        }

        private void butreset_Click(object sender, EventArgs e)
        {
            txtten.Clear();
            txtMaNV.Clear();
            txtdiachi.Clear();
            txtMaNV.Focus();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
                if (txtMaNV.Text == "" || txtten.Text == ""|| txtdiachi.Text == "" || cbotenPB.Text == "")
                    MessageBox.Show("Bạn nhập thiếu thông tin!", "Thông báo");
                else
                {
                try
                {
                    int manv = int.Parse(txtMaNV.Text);
                    int mapb = int.Parse(cbotenPB.SelectedValue.ToString());
                    busql.themnv(manv,mapb, txtten.Text,radNu.Checked.ToString(),dateTimePicker1.Value.ToString(), txtdiachi.Text);
                    MessageBox.Show("Da them thanh cong", "Thong Bao");
                    Form1_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Co loi", "Thong bao");
                }
                }

            }
        }
}
