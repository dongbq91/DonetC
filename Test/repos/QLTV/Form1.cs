using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLTV;
namespace QLTV
{
    public partial class Form1 : Form
    {
        bus_qltv bus = new bus_qltv();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(bus.KiemTra(txtmasach.Text).Rows.Count!=0)
            {
                MessageBox.Show("mã sách đã tồn tại", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if(string.IsNullOrWhiteSpace(txtmasach.Text) || string.IsNullOrWhiteSpace(txtsotrang.Text) || string.IsNullOrWhiteSpace(txttensach.Text))
                {
                    MessageBox.Show("các trường dữ liệu không được để trống", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    int dem = int.Parse(txtsotrang.Text);
                    if(dem>0)
                    {
                        try
                        {
                            bus.insert(txtmasach.Text, txttensach.Text, int.Parse(txtsotrang.Text), comboBox1.SelectedValue.ToString());
                            Form1_Load(sender, e);
                        }
                        catch
                        {
                            MessageBox.Show("lỗi nhập liệu", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("số trang  > 0", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            dt = bus.showSach();
            dataGridView1.DataSource = dt;
            DataTable dt1 = new DataTable();
            dt1 = bus.laydulieucb();
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "tentheloai";
            comboBox1.ValueMember = "matheloai";
            for(int i=0;i<=dataGridView1.Rows.Count-1;i++)
            {
                if(i%2==0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }    
        }
    

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult traLOi = MessageBox.Show("Bạn có muốn xóa sách?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(traLOi==DialogResult.Yes)
            {
                  if(bus.KiemTra(txtmasach.Text).Rows.Count==0)
         {
          MessageBox.Show("Mã sách không tồn tại", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                
          }
                            else
                            {
                
                                bus.delete(txtmasach.Text);
                                Form1_Load(sender, e);
                            }
            }

          
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmasach.Text) || string.IsNullOrWhiteSpace(txtsotrang.Text) || string.IsNullOrWhiteSpace(txttensach.Text))
            {

                MessageBox.Show("các trường dữ liệu không được để trống", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (bus.KiemTra(txtmasach.Text).Rows.Count == 0)
                {
               
                    MessageBox.Show("Mã sách không tồn tại", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        bus.update(txtmasach.Text, txttensach.Text, int.Parse(txtsotrang.Text), comboBox1.SelectedValue.ToString());
                        Form1_Load(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("lỗi nhập liệu", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnhapmoi_Click(object sender, EventArgs e)
        {
            txtmasach.Clear();
            txtsotrang.Clear();
            txttensach.Clear();
            txtmasach.Focus();
        }
    }
}
