﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanlySV
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
            dgvsinhvien.DataSource = dt;
            radnam.Checked = true;
            loadcb();
        }
        void loadcb()
        {
            cbokhoa.DataSource = busql.loadcb();
            cbokhoa.ValueMember = "Makhoa";
            cbokhoa.DisplayMember = "Tenkhoa";
        }
        private void buttthem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtma.Text;
                string ten = txtten.Text;
                DateTime datep = dateTimengaysinh.Value;
                string gt = "";
                if (radnam.Checked == true)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nu";
                }
                int diem = int.Parse(txtdiem.Text);
                string makhoa = cbokhoa.SelectedValue.ToString();
                if (busql.checkma(ma).Rows.Count != 0)
                {
                    MessageBox.Show("Ma da ton tai", "Thong bao");
                }
                else
                {
                    busql.them(ma, ten, datep, diem, makhoa, gt);
                    
                    Form1_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Loi roi ban oi", "Thong bao");
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            
                string ma = txtma.Text;
                string ten = txtten.Text;
                DateTime datep = dateTimengaysinh.Value;
                string gt = "";
                if (radnam.Checked == true)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nu";
                }
                int diem = int.Parse(txtdiem.Text);
                string makhoa = cbokhoa.SelectedValue.ToString();
                if (busql.checkma(ma).Rows.Count == 0) /// nhớ đổi thành == 0
                {
                    MessageBox.Show("Ma khong dung", "Thong bao");
                }
                else
                {
                    busql.update(ma, ten, datep, diem, makhoa, gt);
                    Form1_Load(sender, e);
                }
            
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = txtma.Text;
                if (busql.checkma(ma).Rows.Count == 0)
                {
                    MessageBox.Show("Mã sinh vien không tồn tại");
                }
                else
                {
                    busql.delete(ma);
                    Form1_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mã sinh vien bị lỗi");
            }
        }

        private void butreset_Click(object sender, EventArgs e)
        {
            txtma.Clear();
            txtten.Clear();
            txtdiem.Clear();
            radnam.Checked = true;
            txtma.Focus();
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtma.Text = dgvsinhvien.Rows[index].Cells[0].Value.ToString();
                txtten.Text = dgvsinhvien.Rows[index].Cells[1].Value.ToString();
                dateTimengaysinh.Value = DateTime.Parse(dgvsinhvien.Rows[index].Cells[2].Value.ToString());
                txtdiem.Text = dgvsinhvien.Rows[index].Cells[3].Value.ToString();
                cbokhoa.SelectedValue = dgvsinhvien.Rows[index].Cells[4].Value.ToString();
                string gt = dgvsinhvien.Rows[index].Cells[5].Value.ToString();
                if (gt == "Nu")
                    radnu.Checked = true;
                else
                    radnam.Checked = true;
            }
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtseach.Text;
                if(busql.seach(ten).Rows.Count== 0)
                {
                    MessageBox.Show("Khong co sinh vien nay", "Thong bao");
                }
                else
                {
                    dgvsinhvien.DataSource = busql.seach(ten);
                }
            }
            catch
            {
                MessageBox.Show("Loi roi", "Thong bao");
            }
        }

        private void dgvsinhvien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtma.Text = dgvsinhvien.Rows[index].Cells[0].Value.ToString();
                txtten.Text = dgvsinhvien.Rows[index].Cells[1].Value.ToString();
                dateTimengaysinh.Value = DateTime.Parse(dgvsinhvien.Rows[index].Cells[2].Value.ToString());
                txtdiem.Text = dgvsinhvien.Rows[index].Cells[3].Value.ToString();
                cbokhoa.SelectedValue = dgvsinhvien.Rows[index].Cells[4].Value.ToString();
                string gt = dgvsinhvien.Rows[index].Cells[5].Value.ToString();
                if (gt == "Nu")
                    radnu.Checked = false;
                else
                    radnam.Checked = true;
            }
        }
    }
}
