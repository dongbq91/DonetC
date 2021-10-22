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

namespace BaiKiemTra2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        string connstring = @"Data Source=LAPTOP-8CV1F776\SQLEXPRESS;Initial Catalog=De73;Integrated Security=True";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LayDuLieuDataGridView();
            checkBox1.Checked = false;
            txtMaSach.Focus();
        }

        private void LayDuLieuDataGridView()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select * from Sach";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            dgvSach.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "" || txtTenSach.Text == "" || txtTenSach.Text == "")
                MessageBox.Show("Bạn nhập thiếu thông tin", "Thông báo");
            else
            {
                if(KiemTraMaSach(txtMaSach.Text) == true)
                {
                    MessageBox.Show("Mã sách đã tồn tại", "Thông báo");
                }
                else
                {
                    themSach();
                    LayDuLieuDataGridView();
                }
            }
        }

        private bool KiemTraMaSach(string masach)
        {
            bool check = false;
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select * from Sach where MaSach = '" + masach + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            if (dt.Rows.Count == 0)
            {
                check = false;
            }
            else check = true;
            return check;
        }

        private void themSach()
        {
            string date = "" + dateTimePicker1.Value;
            string day = date.Substring(0, 2);
            string month = date.Substring(3, 2);
            string year = date.Substring(6, 4);
            string nam = year + "/" + month + "/" + day;
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                int check = default;
                if (checkBox1.Checked == true) check = 1;
                else check = 0;
                string insert = "insert into Sach values('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "','" + nam + "','" + txtSoTrang.Text + "','" + check +"')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            } catch
            {
                MessageBox.Show("Lỗi nhập liệu", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtTenSach.Text == "" || txtTenSach.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu thông tin", "Thông báo");
            }
            else
            {
                if(KiemTraMaSach(txtMaSach.Text) == false)
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo");
                }
                else
                {
                    suaSach();
                    LayDuLieuDataGridView();
                }
            }
        }

        private void suaSach()
        {
            string date = "" + dateTimePicker1.Value;
            string day = date.Substring(0, 2);
            string month = date.Substring(3, 2);
            string year = date.Substring(6, 4);
            string nam = year + "/" + month + "/" + day;
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                int check = default;
                if (checkBox1.Checked == true) check = 1;
                else check = 0;
                string update = "update Sach set TenSach = N'" + txtTenSach.Text + "',NamXuatBan = '" + nam + "', SoTrang  = '" + txtSoTrang.Text + "',SachDienTu = '" + check + "' where MaSach = '" + txtMaSach.Text +"'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            } catch
            {
                MessageBox.Show("Có lỗi nhập liệu");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(KiemTraMaSach(txtMaSach.Text) == false || txtMaSach.Text == "")
            {
                MessageBox.Show("Không tìm thấy sách", "Thông báo");
            }
            else
            {
                xoaSach();
                LayDuLieuDataGridView();
            }
        }

        private void xoaSach()
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string delete = "Delete from Sach where MaSach = '" + txtMaSach.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            } catch
            {
                MessageBox.Show("Có lỗi nhập liệu", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSach.Text = dgvSach.Rows[dong].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[dong].Cells[1].Value.ToString();
            txtSoTrang.Text = dgvSach.Rows[dong].Cells[2].Value.ToString();
        }
    }
}
