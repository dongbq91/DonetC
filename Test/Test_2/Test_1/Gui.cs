using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1
{
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }

        private void Gui_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHMTDataSet2.Hang' table. You can move, or remove it, as needed.
            this.hangTableAdapter.Fill(this.qLCHMTDataSet2.Hang);
            // TODO: This line of code loads data into the 'qLCHMTDataSet1.Chungloai' table. You can move, or remove it, as needed.
            this.chungloaiTableAdapter.Fill(this.qLCHMTDataSet1.Chungloai);

        }
    }
}
