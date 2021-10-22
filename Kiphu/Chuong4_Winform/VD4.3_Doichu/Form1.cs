using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD4._3_Doichu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butkq_Click(object sender, EventArgs e)
        {
            string hoten = this.txthoten.Text.Trim();
            if (this.radthuong.Checked == true)
                txtkq.Text = hoten.ToLower();
            if (this.radhoa.Checked == true)
                txtkq.Text = hoten.ToUpper();
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            this.txthoten.Clear();
            this.txtkq.Clear();
            this.radthuong.Checked = true;
            this.txthoten.Focus();
        }
    }
}
