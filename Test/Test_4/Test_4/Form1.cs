using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_T4;

namespace Test_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLsachDataSet1.Theloai' table. You can move, or remove it, as needed.
            this.theloaiTableAdapter.Fill(this.qLsachDataSet1.Theloai);
            // TODO: This line of code loads data into the 'qLsachDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLsachDataSet.Sach);

        }
        Bus_cl bus = new Bus_cl();

        private void buthem_Click(object sender, EventArgs e)
        {
            if(bus.kiemtra(txtma.Text).Rows.Count != 0)
            {
                MessageBox.Show("Co loi ");
            }
            else
            {
                try
                {
                    int sotrang = int.Parse(txtsotrang.Text);
                    {
                        if (sotrang > 0)
                        {
                            bus.them(txtma.Text, txtten.Text, int.Parse(txtsotrang.Text), cbomatheloai.SelectedValue.ToString());
                            Form1_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("So trang phai lon hon 0 ", "Thong bao ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Looi nhap lieu", " Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
