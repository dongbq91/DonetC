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

namespace BT_Form_ADO_BTL
{
    public partial class TTSP : Form
    {
        public TTSP()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connstring = @"Data Source=DONGBQ-PC;Initial Catalog=QLBH;Integrated Security=True";

        private void TTSP_Load(object sender, EventArgs e)
        {
            LaydulieuDataview();
            LaydulieuTenhang();
            txtmasp.Focus();
        }
        private void LaydulieuDataview()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = " select Masp , Tensp , mausac , soluong , giaban , Hangsx.Tenhang from Sanpham , Hangsx ";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            dataview1.DataSource = dt;
        }
        private void LaydulieuTenhang()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = " select Mahang,Tenhang  from Hangsx";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cbotenhang.DataSource = dt;
            cbotenhang.DisplayMember = "Tenhang";
            cbotenhang.ValueMember = "Mahang";
        }
        
        private void butnhap_Click(object sender, EventArgs e)
        {
            if(txtmasp.Text =="" || txttensp.Text == ""|| txtmau.Text == ""|| txtsl.Text == ""|| txtgia.Text == ""|| cbotenhang.Text == "")
                MessageBox.Show("B???n nh???p thi???u th??ng tin!", "Th??ng b??o");
            else
            {
                themmoinv();
                LaydulieuDataview();
            }
        }
        private void themmoinv()
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string strInsert = " insert into Sanpham values ('" + txtmasp.Text + "',N'" + txttensp.Text + "',N'" + txtmau.Text + "', '" + txtsl.Text + "','" + txtgia.Text + "','" + cbotenhang.SelectedValue + "' )";
                SqlCommand cmd = new SqlCommand(strInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("C?? l???i b???n ??i", "Th??ng b??o ");
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if(KiemtraSP(int.Parse(txtmasp.Text))== false)
            {
                MessageBox.Show("L??m g?? c?? s???n ph???m n??y ! ", " Th??ng b??o ");
            }
            else
            {
                xoadulieu();
                LaydulieuDataview();
            }
        }
        private bool KiemtraSP(int manv)
        {
            bool ktra = false;
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = " Select * from Sanpham where Masp = '" + manv + "'";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            if (dt.Rows.Count == 0)
                ktra = false;
            else
                ktra = true;
            return ktra;
        }
        private void xoadulieu()
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string strDelete = " Delete from Sanpham where Masp = '" + txtmasp.Text + "' ";
                SqlCommand cmd = new SqlCommand(strDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("C?? l???i b???n ??i !", " Th??ng b??o ");
            }
        }


        private void dataview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtmasp.Text = dataview1.Rows[numrow].Cells[0].value.Tostring();
            txtgia.Text = dataview1.Rows[numrow].Cells[1].value.Tostring();
            txtsl.Text = dataview1.Rows[numrow].Cells[2].value.Tostring();
            txtmau.Text = dataview1.Rows[numrow].Cells[3].value.Tostring();
            txtmau.Text = dataview1.Rows[Rows]. Cells[4].value.Tostring();
        }
        private void private 
    }
}
