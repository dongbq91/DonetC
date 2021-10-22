using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BT_Form_ADO
{
    public partial class BTSQL : Form
    {
        public BTSQL()
        {
            InitializeComponent();
        }

        private void BTSQL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet1.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.qLNSDataSet1.Departments);

        }

        private void butthem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
