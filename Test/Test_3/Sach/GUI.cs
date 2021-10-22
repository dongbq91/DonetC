using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_T3;

namespace Sach
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }
        

        private void GUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLsachDataSet1.Theloai' table. You can move, or remove it, as needed.
            this.theloaiTableAdapter.Fill(this.qLsachDataSet1.Theloai);
            // TODO: This line of code loads data into the 'qLsachDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLsachDataSet.Sach);

        }
        Bus bus = new Bus();

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Ban co muon xoa ko ", "Thong bao", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (DialogResult.Yes == hoi)
            {
                if (bus.kiemtra(txtma.Text).Rows.Count == 0)
                {
                    MessageBox.Show("Ma sach ko ton tai", "Thong bao");
                }
                else
                {
                    bus.xoa(txtma.Text);
                    GUI_Load(sender, e);
                }
            }

        }

        private void butthem_Click(object sender, EventArgs e)
        {
            if(bus.kiemtra(txtma.Text).Rows.Count != 0)
            {
                MessageBox.Show("Ma sach da ton tai ", "Thong Bao");
            }
            else
            {
                try
                {
                    int sotrang = int.Parse(txtsotrang.Text);
                    if (sotrang > 0)
                    {
                        bus.them(txtma.Text, txtten.Text, int.Parse(txtsotrang.Text), cbotheloai.SelectedValue.ToString());
                        GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("So trang lon hon 0 ", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }
                }
                catch
                {
                    MessageBox.Show("Loi roi ", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
