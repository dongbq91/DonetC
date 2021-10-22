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

namespace De1
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
        }
        private void butnhap_Click(object sender, EventArgs e)
        {
            
                string ma = txtma.Text;
                string ten = txtten.Text;
                string luuy = cboluuy.SelectedItem.ToString();
                DateTime datep = datepickngay.Value;
                
                int sl = int.Parse(txtsl.Text);
                
                if (busql.checkma(ma).Rows.Count != 0) 
                {
                    MessageBox.Show("Ma khong dung", "Thong bao");
                }
                else
                {
                    busql.them(ma, ten, luuy, datep,sl);
                    MessageBox.Show("Them thanh cong");
                    Form1_Load(sender, e);
                }
            
           
        }

        private void dgvhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtma.Text = dgvhang.Rows[index].Cells[0].Value.ToString();
                txtten.Text = dgvhang.Rows[index].Cells[1].Value.ToString();
                cboluuy.Text = dgvhang.Rows[index].Cells[2].Value.ToString();
                datepickngay.Value = DateTime.Parse(dgvhang.Rows[index].Cells[3].Value.ToString());
                txtsl.Text = dgvhang.Rows[index].Cells[4].Value.ToString();
            }
        }
    }
}
