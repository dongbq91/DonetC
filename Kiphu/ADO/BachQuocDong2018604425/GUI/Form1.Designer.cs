
namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.dgvkhach = new System.Windows.Forms.DataGridView();
            this.butthem = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtsophong = new System.Windows.Forms.TextBox();
            this.dateTimecheck = new System.Windows.Forms.DateTimePicker();
            this.checknu = new System.Windows.Forms.CheckBox();
            this.butthoat = new System.Windows.Forms.Button();
            this.Makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sophong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaycheckin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(120, 38);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(214, 20);
            this.txtma.TabIndex = 1;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(120, 109);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(100, 20);
            this.txtcmnd.TabIndex = 2;
            // 
            // dgvkhach
            // 
            this.dgvkhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makhachhang,
            this.Tenkhachhang,
            this.Socmnd,
            this.Sophong,
            this.gioitinh,
            this.Ngaycheckin});
            this.dgvkhach.Location = new System.Drawing.Point(12, 228);
            this.dgvkhach.Name = "dgvkhach";
            this.dgvkhach.Size = new System.Drawing.Size(700, 125);
            this.dgvkhach.TabIndex = 4;
            this.dgvkhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhach_CellClick);
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(493, 36);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 5;
            this.butthem.Text = "Nhập";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(493, 77);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 6;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(493, 124);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 7;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày check in";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(120, 77);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(214, 20);
            this.txtten.TabIndex = 12;
            // 
            // txtsophong
            // 
            this.txtsophong.Location = new System.Drawing.Point(120, 144);
            this.txtsophong.Name = "txtsophong";
            this.txtsophong.Size = new System.Drawing.Size(100, 20);
            this.txtsophong.TabIndex = 13;
            // 
            // dateTimecheck
            // 
            this.dateTimecheck.CustomFormat = "MM / dd / yyyy";
            this.dateTimecheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimecheck.Location = new System.Drawing.Point(120, 183);
            this.dateTimecheck.Name = "dateTimecheck";
            this.dateTimecheck.Size = new System.Drawing.Size(113, 20);
            this.dateTimecheck.TabIndex = 14;
            // 
            // checknu
            // 
            this.checknu.AutoSize = true;
            this.checknu.Location = new System.Drawing.Point(368, 128);
            this.checknu.Name = "checknu";
            this.checknu.Size = new System.Drawing.Size(40, 17);
            this.checknu.TabIndex = 15;
            this.checknu.Text = "Nữ";
            this.checknu.UseVisualStyleBackColor = true;
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(493, 183);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 16;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // Makhachhang
            // 
            this.Makhachhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Makhachhang.DataPropertyName = "Makhachhang";
            this.Makhachhang.HeaderText = "Mã khách hàng";
            this.Makhachhang.Name = "Makhachhang";
            // 
            // Tenkhachhang
            // 
            this.Tenkhachhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenkhachhang.DataPropertyName = "Tenkhachhang";
            this.Tenkhachhang.HeaderText = "Tên Khách Hàng";
            this.Tenkhachhang.Name = "Tenkhachhang";
            // 
            // Socmnd
            // 
            this.Socmnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Socmnd.DataPropertyName = "Socmnd";
            this.Socmnd.HeaderText = "Số CMND";
            this.Socmnd.Name = "Socmnd";
            // 
            // Sophong
            // 
            this.Sophong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sophong.DataPropertyName = "Sophong";
            this.Sophong.HeaderText = "Số phòng";
            this.Sophong.Name = "Sophong";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // Ngaycheckin
            // 
            this.Ngaycheckin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngaycheckin.DataPropertyName = "Ngaycheckin";
            this.Ngaycheckin.HeaderText = "Ngày check in";
            this.Ngaycheckin.Name = "Ngaycheckin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quản lý khách sạn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 365);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.checknu);
            this.Controls.Add(this.dateTimecheck);
            this.Controls.Add(this.txtsophong);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.dgvkhach);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.DataGridView dgvkhach;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtsophong;
        private System.Windows.Forms.DateTimePicker dateTimecheck;
        private System.Windows.Forms.CheckBox checknu;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sophong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaycheckin;
        private System.Windows.Forms.Label label6;
    }
}

