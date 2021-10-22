using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD1_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butok_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "You choose : ";
            this.txtkq.Text += this.cboweb.SelectedItem.ToString();    
        }

        private void butreset_Click(object sender, EventArgs e)
        {
            this.txtkq.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cboweb.Items.Add("Ấn vào đê");
            this.cboweb.Items.Add("Ấn thử vào đê");
            this.cboweb.Items.Add("Ấn thử vào xem đê");
            this.cboweb.Items.Add("Ấn hộ đê");
            this.cboweb.SelectedItem = "Ấn vào đê";
        }
    }
}
