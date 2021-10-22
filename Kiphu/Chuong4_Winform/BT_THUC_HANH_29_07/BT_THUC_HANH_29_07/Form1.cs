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

namespace BT_THUC_HANH_29_07
{
    public partial class FormSanPham : Form
    {
        SqlConnection conn;
        string connstring = @"Data Source=LAPTOP-8CV1F776\SQLEXPRESS;Initial Catalog=QLBH_TH_29_07;Integrated Security=True";

        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            LayDuLieuDataGridView();
            LayDuLieuTenHang();
            txtMaSP.Focus();
        }

        private void LayDuLieuDataGridView()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select MaSP,TenSP,MauSac,SoLuong,GiaBan,TenHang from SanPham inner join HangSX on SanPham.MaHang = HangSX.MaHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            dgvSanPham.DataSource = dt;
        }

        private void LayDuLieuTenHang()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select MaHang,TenHang from HangSX";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboTenHang.DataSource = dt;
            cboTenHang.DisplayMember = "TenHang";
            cboTenHang.ValueMember = "MaHang";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaSP.Text == "" || txtTenSP.Text == "" || txtMauSac.Text == "" ||
                txtSoLuong.Text == "" || txtGiaBan.Text == "" || cboTenHang.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Thông báo");
            }
            else
            {
                if(KiemTraMaSP(txtMaSP.Text) == true)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo");
                }
                else
                {
                    themSanPham();
                    LayDuLieuDataGridView();
                }
            }
        }

        private void themSanPham()
        {
            int soluong = int.Parse(txtSoLuong.Text);
            int giaban = int.Parse(txtGiaBan.Text);
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string insert = "insert into SanPham values('" + txtMaSP.Text + "',N'"
                    + txtTenSP.Text + "',N'" + txtMauSac.Text + "','" + soluong + "','"
                    + giaban + "','" + cboTenHang.SelectedValue + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            } catch
            {
                MessageBox.Show("Có lỗi nhập liệu", "Thông báo");
            }
        }

        private bool KiemTraMaSP(string masp)
        {
            bool check = false;
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select * from SanPham where MaSP = '" + masp + "'";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(KiemTraMaSP(txtMaSP.Text) == false)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo");
            }
            else
            {
                xoaSanPham();
                LayDuLieuDataGridView();
            }
        }

        private void xoaSanPham()
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string delete = "Delete from SanPham where MaSP = '" + txtMaSP.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            } catch {
                MessageBox.Show("Có lỗi nhập liệu!", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(KiemTraMaSP(txtMaSP.Text) == false)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo");
            }
            else
            {
                if(txtTenSP.Text == "" || txtMauSac.Text == "" ||
                txtSoLuong.Text == "" || txtGiaBan.Text == "" || cboTenHang.Text == "")
                {
                    MessageBox.Show("Bạn nhập thiếu thông tin!", "Thông báo");
                }
                else
                {
                    suaSanPham();
                    LayDuLieuDataGridView();
                }
            }
        }

        private void suaSanPham()
        {
            int soluong = int.Parse(txtSoLuong.Text);
            int giaban = int.Parse(txtGiaBan.Text);
            string mahang = cboTenHang.SelectedValue.ToString();
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string update = "Update SanPham set TenSP = N'" + txtTenSP.Text + "',MauSac = N'" + txtMauSac.Text + "',SoLuong = '" + soluong + "', GiaBan = '"
                    + giaban + "',MaHang = '" + mahang.Substring(0,3) + "' where MaSP = '" + txtMaSP.Text + "'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            } catch
            {
                MessageBox.Show("Có lỗi nhập liệu", "Thông báo");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            LayDuLieuTenHang();
            txtTenSP.Clear();
            txtMauSac.Clear();
            txtSoLuong.Clear();
            txtGiaBan.Clear();
            txtMaSP.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ok = new DialogResult();
            ok = MessageBox.Show("Bạn có muốn thoát?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.Yes)
                Application.Exit();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            txtMaSP.Text = dgvSanPham.Rows[numRow].Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.Rows[numRow].Cells[1].Value.ToString();
            txtMauSac.Text = dgvSanPham.Rows[numRow].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvSanPham.Rows[numRow].Cells[3].Value.ToString();
            txtGiaBan.Text = dgvSanPham.Rows[numRow].Cells[4].Value.ToString();
            cboTenHang.Text = dgvSanPham.Rows[numRow].Cells[5].Value.ToString();
        }
    }
}
