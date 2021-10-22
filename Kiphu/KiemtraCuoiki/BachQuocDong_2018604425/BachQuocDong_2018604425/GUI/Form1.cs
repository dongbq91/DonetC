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


namespace GUI
{
    public partial class Form1 : Form
    {
        Bus_ql busql = new Bus_ql();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = busql.show();
            dgvhang.DataSource = dt;
            
            loadcb();
        }
        void loadcb()
        {
            cboloai.DataSource = busql.loadcb();
            cboloai.ValueMember = "Maloai";
            cboloai.DisplayMember = "Tenloai";
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtma.Text;
                string ten = txtten.Text;
                string gia = txtgia.Text;
                string maloai = cboloai.SelectedValue.ToString();
                if ( txtma.Text=="" || txtten.Text =="" ||txtgia.Text == "")
                {
                    MessageBox.Show("Nhap thieu", "Thong bao");

                }
                else
                {
                    if (busql.checkma(ma).Rows.Count != 0)
                    {
                        MessageBox.Show("Ma da ton tai", "Thong bao");
                    }
                    else
                    {
                        busql.them(ma, ten, gia, maloai);
                        MessageBox.Show("Them thanh cong");
                        Form1_Load(sender, e);
                    }
                }
                
                
            }
            catch
            {
                MessageBox.Show("Loi roi ban oi", "Thong bao");
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttim_Click(object sender, EventArgs e)
        {
            try
            {
                string maloai = cboloai.SelectedValue.ToString();
                if (busql.seach(maloai).Rows.Count == 0)
                {
                    MessageBox.Show("Khong co hang nay", "Thong bao");
                }
                else
                {
                    dgvhang.DataSource = busql.seach(maloai);
                }
            }
            catch
            {
                MessageBox.Show("Khong co gi", "Thong bao");
            }
        }
    }
}
