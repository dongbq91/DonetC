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

namespace QLHangMaytinh
{
    public partial class formhang : Form
    {
        Bus_ql busql = new Bus_ql();
        public formhang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHMTDataSet6.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter3.Fill(this.qLHMTDataSet6.Product);
            // TODO: This line of code loads data into the 'qLHMTDataSet5.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter2.Fill(this.qLHMTDataSet5.Product);
            // TODO: This line of code loads data into the 'qLHMTDataSet4.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.qLHMTDataSet4.Product);
            // TODO: This line of code loads data into the 'qLHMTDataSet3.Product' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLHMTDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.qLHMTDataSet.Category);


            DataTable dt = new DataTable();
            dt = busql.showhang();
            dgvhang.DataSource = dt;
        }

        private void butnhap_Click(object sender, EventArgs e)
        {
            
                string ma = txtmahang.Text;
                string ten = txttenhang.Text;
                int slc = int.Parse(txtslc.Text);
                DateTime datep = datetimepick.Value;
                //string mahangg = cboloai.SelectedValue.ToString();
                string nsx = txtnsx.Text;
                if (busql.checkma(ma).Rows.Count != 0)
                {
                    MessageBox.Show("Ma da ton tai", "Thong bao");
                }
                else
                {
                    busql.them(ma, ten, slc, nsx,datep);
                    Form1_Load(sender, e);
                }
            
          
        }

        private void butxua_Click(object sender, EventArgs e)
        {

        }

        private void butxoa_Click(object sender, EventArgs e)
        {

        }

        private void buttim_Click(object sender, EventArgs e)
        {

        }

        private void butreset_Click(object sender, EventArgs e)
        {
            txtmahang.Clear();
            txttenhang.Clear();
            txtslc.Clear();
            txtnsx.Clear();
            txtmahang.Focus();
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtmahang.Text = dgvhang.Rows[index].Cells[0].Value.ToString();
                txttenhang.Text = dgvhang.Rows[index].Cells[1].Value.ToString();
                txtslc.Text = dgvhang.Rows[index].Cells[2].Value.ToString();
                txtnsx.Text = dgvhang.Rows[index].Cells[3].Value.ToString();
                datetimepick.Value = DateTime.Parse(dgvhang.Rows[index].Cells[4].Value.ToString());
            }
        }
    }
}
