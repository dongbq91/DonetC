using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data;

namespace QLBH
{
    public partial class Form1 : Form
    {
        Bussp busql = new Bussp();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHADODataSet1.HangSX' table. You can move, or remove it, as needed.
            this.hangSXTableAdapter.Fill(this.qLBHADODataSet1.HangSX);
            // TODO: This line of code loads data into the 'qLBHADODataSet1.HangSX' table. You can move, or remove it, as needed.
            this.hangSXTableAdapter.Fill(this.qLBHADODataSet1.HangSX);
            // TODO: This line of code loads data into the 'qLBHADODataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qLBHADODataSet.SanPham);

            DataTable dt = new DataTable();
            dt = busql.showql();
            dgvsanpham.DataSource = dt;
        }

        private void butnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtmasp.Text;
                string ten = txttensp.Text;
                string mauu = txtmau.Text;
                int sll = int.Parse(txtsl.Text);
                int gial = int.Parse(txtgia.Text);
                string mahangg = cbohang.SelectedValue.ToString();
                if (busql.checkma(ma).Rows.Count != 0)
                {
                    MessageBox.Show("Ma da ton tai", "Thong bao");
                }
                else
                {
                    busql.them(ma, ten, mauu, sll, gial, mahangg);
                    Form1_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Loi nhap ", "Thong bao");
            }
        }

        private void butreset_Click(object sender, EventArgs e)
        {
            txtmasp.Clear();
            txttensp.Clear();
            txtmau.Clear();
            txtgia.Clear();
            txtsl.Clear();
            txtmasp.Focus();
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = txtmasp.Text;
                if (busql.checkma(ma).Rows.Count == 0)
                {
                    MessageBox.Show("Mã sách không tồn tại");
                }
                else
                {
                    busql.delete(ma);
                    Form1_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mã Sách bị lỗi");
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtmasp.Text;
                string ten = txttensp.Text;
                string mauu = txtmau.Text;
                int sll = int.Parse(txtsl.Text);
                int gial = int.Parse(txtgia.Text);
                string mahangg = cbohang.SelectedValue.ToString();
                if (busql.checkma(ma).Rows.Count == 0)
                {
                    MessageBox.Show("Ma ko ton tai", "Thong bao");
                }
                else
                {
                    busql.update(ma, ten, mauu, sll, gial, mahangg);
                    Form1_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Loi roi ban oi", "Thong bao");
            }
            
        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahang;
            int row = e.RowIndex;
            if(row >= 0)
            {
                txtmasp.Text = dgvsanpham.Rows[row].Cells[0].Value.ToString();
                txttensp.Text = dgvsanpham.Rows[row].Cells[1].Value.ToString();
                txtmau.Text = dgvsanpham.Rows[row].Cells[2].Value.ToString();
                txtsl.Text = dgvsanpham.Rows[row].Cells[3].Value.ToString();
                txtgia.Text = dgvsanpham.Rows[row].Cells[4].Value.ToString();
                mahang = dgvsanpham.Rows[row].Cells[5].Value.ToString();
                cbohang.Text = busql.selectpb(mahang);
            }
        }
    }
}
    
