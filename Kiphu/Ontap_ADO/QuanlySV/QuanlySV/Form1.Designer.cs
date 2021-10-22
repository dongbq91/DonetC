
namespace QuanlySV
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
            this.components = new System.ComponentModel.Container();
            this.buttthem = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butreset = new System.Windows.Forms.Button();
            this.buttimkiem = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.dateTimengaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.cbokhoa = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.radnam = new System.Windows.Forms.RadioButton();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.sinhvienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtseach = new System.Windows.Forms.TextBox();
            this.dgvsinhvien = new System.Windows.Forms.DataGridView();
            this.sinhvienBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
   
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttthem
            // 
            this.buttthem.Location = new System.Drawing.Point(392, 31);
            this.buttthem.Name = "buttthem";
            this.buttthem.Size = new System.Drawing.Size(75, 23);
            this.buttthem.TabIndex = 0;
            this.buttthem.Text = "Nhập";
            this.buttthem.UseVisualStyleBackColor = true;
            this.buttthem.Click += new System.EventHandler(this.buttthem_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(509, 31);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 1;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(392, 81);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 2;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butreset
            // 
            this.butreset.Location = new System.Drawing.Point(509, 81);
            this.butreset.Name = "butreset";
            this.butreset.Size = new System.Drawing.Size(75, 23);
            this.butreset.TabIndex = 3;
            this.butreset.Text = "Reset";
            this.butreset.UseVisualStyleBackColor = true;
            this.butreset.Click += new System.EventHandler(this.butreset_Click);
            // 
            // buttimkiem
            // 
            this.buttimkiem.Location = new System.Drawing.Point(509, 123);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(75, 23);
            this.buttimkiem.TabIndex = 4;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(509, 163);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 5;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // dateTimengaysinh
            // 
            this.dateTimengaysinh.CustomFormat = "MM / dd /yyyy";
            this.dateTimengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimengaysinh.Location = new System.Drawing.Point(124, 109);
            this.dateTimengaysinh.Name = "dateTimengaysinh";
            this.dateTimengaysinh.Size = new System.Drawing.Size(144, 20);
            this.dateTimengaysinh.TabIndex = 7;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(124, 31);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 8;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(124, 71);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 9;
            // 
            // txtdiem
            // 
            this.txtdiem.Location = new System.Drawing.Point(124, 150);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(100, 20);
            this.txtdiem.TabIndex = 10;
            // 
            // cbokhoa
            // 
            this.cbokhoa.DataSource = this.khoaBindingSource;
            this.cbokhoa.DisplayMember = "Tenkhoa";
            this.cbokhoa.FormattingEnabled = true;
            this.cbokhoa.Location = new System.Drawing.Point(124, 223);
            this.cbokhoa.Name = "cbokhoa";
            this.cbokhoa.Size = new System.Drawing.Size(121, 21);
            this.cbokhoa.TabIndex = 11;
            this.cbokhoa.ValueMember = "Makhoa";
            // 
            // khoaBindingSource
            // 

            // qLSVV1DataSet
            // 

            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(124, 184);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(47, 17);
            this.radnam.TabIndex = 12;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(185, 184);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(39, 17);
            this.radnu.TabIndex = 13;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nu";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // qLSVV1DataSet2
            // 

            // txtseach
            // 
            this.txtseach.Location = new System.Drawing.Point(392, 125);
            this.txtseach.Name = "txtseach";
            this.txtseach.Size = new System.Drawing.Size(100, 20);
            this.txtseach.TabIndex = 15;
            // 
            // dgvsinhvien
            // 
            this.dgvsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masv,
            this.Tensv,
            this.Ngaysinh,
            this.Diem,
            this.gioitinh,
            this.Tenkhoa});
            this.dgvsinhvien.Location = new System.Drawing.Point(12, 267);
            this.dgvsinhvien.Name = "dgvsinhvien";
            this.dgvsinhvien.Size = new System.Drawing.Size(639, 97);
            this.dgvsinhvien.TabIndex = 16;
            this.dgvsinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsinhvien_CellClick_1);
            // 
            // sinhvienBindingSource3
            // 

            // Masv
            // 
            this.Masv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Masv.DataPropertyName = "Masv";
            this.Masv.HeaderText = "Mã sinh vien";
            this.Masv.Name = "Masv";
            // 
            // Tensv
            // 
            this.Tensv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tensv.DataPropertyName = "Tensv";
            this.Tensv.HeaderText = "Tên sinh viên";
            this.Tensv.Name = "Tensv";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh ";
            this.Ngaysinh.Name = "Ngaysinh";
            // 
            // Diem
            // 
            this.Diem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diem.DataPropertyName = "Diem";
            this.Diem.HeaderText = "Điểm";
            this.Diem.Name = "Diem";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // Tenkhoa
            // 
            this.Tenkhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenkhoa.DataPropertyName = "Tenkhoa";
            this.Tenkhoa.HeaderText = "Tên khoa";
            this.Tenkhoa.Name = "Tenkhoa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 376);
            this.Controls.Add(this.dgvsinhvien);
            this.Controls.Add(this.txtseach);
            this.Controls.Add(this.radnu);
            this.Controls.Add(this.radnam);
            this.Controls.Add(this.cbokhoa);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.dateTimengaysinh);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.buttimkiem);
            this.Controls.Add(this.butreset);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.buttthem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttthem;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butreset;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.DateTimePicker dateTimengaysinh;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.ComboBox cbokhoa;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.BindingSource sinhvienBindingSource1;
        private System.Windows.Forms.BindingSource sinhvienBindingSource2;
        private System.Windows.Forms.TextBox txtseach;
        private System.Windows.Forms.DataGridView dgvsinhvien;
        private System.Windows.Forms.BindingSource sinhvienBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhoa;
    }
}

