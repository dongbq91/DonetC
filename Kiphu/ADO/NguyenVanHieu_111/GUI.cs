using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenVanHieu.BUS;
namespace NguyenVanHieu
{
    public partial class GUI : Form
    {
        Bus bus = new Bus();
        public GUI()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GUI_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.getSach();
            loadcb();
        }
        void loadcb()
        {
            cbTheLoai.DataSource = bus.loadcb();
            cbTheLoai.DisplayMember = "TenTheLoai";
            cbTheLoai.ValueMember = "MaTheLoai";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String maSach = txtMaSach.Text;
                String tenSach = txtTenSach.Text;
                int soTrang = int.Parse(txtSoTrang.Text);
                String maTheLoai = cbTheLoai.SelectedValue.ToString();
                if (bus.check(maSach).Rows.Count != 0)
                {
                    MessageBox.Show("Mã sách đã tồn tại");
                }
                else
                {
                    bus.ThemSach(maSach, tenSach, soTrang, maTheLoai);
                    GUI_Load(sender, e);
                }
            }
               
           catch(Exception)
            {
                MessageBox.Show("Lỗi nhập dữ liệu!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                String maSach = txtMaSach.Text;
                String tenSach = txtTenSach.Text;
                int soTrang = int.Parse(txtSoTrang.Text);
                String maTheLoai = cbTheLoai.SelectedValue.ToString();
                if (bus.check(maSach).Rows.Count == 0)
                {
                    MessageBox.Show("Mã sách không tồn tại");
                }
                else
                {
                    bus.SuaSach(maSach, tenSach, soTrang, maTheLoai);
                    GUI_Load(sender, e);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Lỗi nhập dữ liệu!!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                String ms = txtMaSach.Text;
                if (bus.check(ms).Rows.Count == 0)
                {
                    MessageBox.Show("Mã sách không tồn tại");
                }
                else
                {
                    bus.xoaSach(ms);
                    GUI_Load(sender, e);
                }
            }catch(Exception)
            {
                MessageBox.Show("Mã Sách bị lỗi");
            }
           
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {

            try
            {
                String tenSach = txtTenSach.Text;
                if (bus.Search(tenSach).Rows.Count == 0)
                {
                    MessageBox.Show("Tên sách không tồn tại");
                }
                else
                {

                    dataGridView1.DataSource = bus.Search(tenSach);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tên sách không được để trống");
            }
        }
    }
}
