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
            dgvkhach.DataSource = dt;
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtma.Text;
                string ten = txtten.Text;
                int cmt = int.Parse(txtcmnd.Text);
                int so = int.Parse(txtsophong.Text);
                
                string gt = "";
                if (checknu.Checked == true)
                {
                    gt = "Nu";
                }
                DateTime datep = dateTimecheck.Value;

               
                if (busql.checkma(ma).Rows.Count != 0)
                {
                    MessageBox.Show("Mã đã tồn tại", "Thông báo");
                }
                else
                {
                    busql.them(ma, ten, cmt, so, gt,datep);
                    MessageBox.Show("Thêm thành công ");
                    Form1_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi", "Thông báo");
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtma.Text;
                string ten = txtten.Text;
                int cmt = int.Parse(txtcmnd.Text);
                int so = int.Parse(txtsophong.Text);

                string gt = "";
                if (checknu.Checked == true)
                {
                    gt = "Nu";
                }
                DateTime datep = dateTimecheck.Value;


                if (busql.checkma(ma).Rows.Count == 0)
                {
                    MessageBox.Show("Mã không tồn tại", "Thông báo");
                }
                else
                {
                    busql.update(ma, ten, cmt, so, gt, datep);
                    MessageBox.Show("Sửa thành công");
                    Form1_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi", "Thông báo");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = txtma.Text;
                if (busql.checkma(ma).Rows.Count == 0)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại");
                }
                else
                {
                    busql.delete(ma);
                    MessageBox.Show("Đã xóa thành công");
                    Form1_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi", "Thông báo");
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvkhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtma.Text = dgvkhach.Rows[index].Cells[0].Value.ToString();
                txtten.Text = dgvkhach.Rows[index].Cells[1].Value.ToString();
                txtcmnd.Text = dgvkhach.Rows[index].Cells[2].Value.ToString();
                txtsophong.Text = dgvkhach.Rows[index].Cells[3].Value.ToString();
                
                if (dgvkhach.Rows[index].Cells[4].Value.ToString().Contains("Nu"))
                {
                    checknu.Checked = true;
                }
                else
                {
                    checknu.Checked = false;
                }
                dateTimecheck.Value = DateTime.Parse(dgvkhach.Rows[index].Cells[5].Value.ToString());
            }
        }
    }
}
