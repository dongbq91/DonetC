using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_CHMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLMTDataSet2.Loai' table. You can move, or remove it, as needed.
            this.loaiTableAdapter1.Fill(this.qLMTDataSet2.Loai);
            // TODO: This line of code loads data into the 'qLMTDataSet1.Hang' table. You can move, or remove it, as needed.
            this.hangTableAdapter.Fill(this.qLMTDataSet1.Hang);
            // TODO: This line of code loads data into the 'qLMTDataSet.Loai' table. You can move, or remove it, as needed.
            this.loaiTableAdapter.Fill(this.qLMTDataSet.Loai);

        }
    }
}
