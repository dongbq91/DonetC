
namespace QLBH
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
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHADODataSet = new QLBH.QLBHADODataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butnhap = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butreset = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmau = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.cbohang = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHADODataSet1 = new QLBH.QLBHADODataSet1();
            this.sanPhamTableAdapter = new QLBH.QLBHADODataSetTableAdapters.SanPhamTableAdapter();
            this.hangSXTableAdapter = new QLBH.QLBHADODataSet1TableAdapters.HangSXTableAdapter();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mausacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHADODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHADODataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.AutoGenerateColumns = false;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSPDataGridViewTextBoxColumn,
            this.mausacDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.giabanDataGridViewTextBoxColumn,
            this.maHangDataGridViewTextBoxColumn,
            this.maSPDataGridViewTextBoxColumn});
            this.dgvsanpham.DataSource = this.sanPhamBindingSource;
            this.dgvsanpham.Location = new System.Drawing.Point(0, 238);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.Size = new System.Drawing.Size(637, 129);
            this.dgvsanpham.TabIndex = 0;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.qLBHADODataSet;
            // 
            // qLBHADODataSet
            // 
            this.qLBHADODataSet.DataSetName = "QLBHADODataSet";
            this.qLBHADODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MaSP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Màu Sắc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên Hãng";
            // 
            // butnhap
            // 
            this.butnhap.Location = new System.Drawing.Point(445, 23);
            this.butnhap.Name = "butnhap";
            this.butnhap.Size = new System.Drawing.Size(75, 23);
            this.butnhap.TabIndex = 7;
            this.butnhap.Text = "Nhập";
            this.butnhap.UseVisualStyleBackColor = true;
            this.butnhap.Click += new System.EventHandler(this.butnhap_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(445, 61);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 8;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(445, 110);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 9;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butreset
            // 
            this.butreset.Location = new System.Drawing.Point(445, 147);
            this.butreset.Name = "butreset";
            this.butreset.Size = new System.Drawing.Size(75, 23);
            this.butreset.TabIndex = 10;
            this.butreset.Text = "Thêm mới";
            this.butreset.UseVisualStyleBackColor = true;
            this.butreset.Click += new System.EventHandler(this.butreset_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(445, 190);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 11;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(128, 23);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(110, 20);
            this.txtmasp.TabIndex = 12;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(128, 63);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(219, 20);
            this.txttensp.TabIndex = 13;
            // 
            // txtmau
            // 
            this.txtmau.Location = new System.Drawing.Point(128, 96);
            this.txtmau.Name = "txtmau";
            this.txtmau.Size = new System.Drawing.Size(219, 20);
            this.txtmau.TabIndex = 14;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(128, 126);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(100, 20);
            this.txtsl.TabIndex = 15;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(128, 160);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(100, 20);
            this.txtgia.TabIndex = 16;
            // 
            // cbohang
            // 
            this.cbohang.DataSource = this.bindingSource1;
            this.cbohang.DisplayMember = "TenHang";
            this.cbohang.Location = new System.Drawing.Point(128, 192);
            this.cbohang.Name = "cbohang";
            this.cbohang.Size = new System.Drawing.Size(121, 21);
            this.cbohang.TabIndex = 0;
            this.cbohang.ValueMember = "MaHang";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "HangSX";
            this.bindingSource1.DataSource = this.qLBHADODataSet1;
            // 
            // qLBHADODataSet1
            // 
            this.qLBHADODataSet1.DataSetName = "QLBHADODataSet1";
            this.qLBHADODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // hangSXTableAdapter
            // 
            this.hangSXTableAdapter.ClearBeforeFill = true;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // mausacDataGridViewTextBoxColumn
            // 
            this.mausacDataGridViewTextBoxColumn.DataPropertyName = "Mausac";
            this.mausacDataGridViewTextBoxColumn.HeaderText = "Mausac";
            this.mausacDataGridViewTextBoxColumn.Name = "mausacDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "Soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Soluong";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // giabanDataGridViewTextBoxColumn
            // 
            this.giabanDataGridViewTextBoxColumn.DataPropertyName = "giaban";
            this.giabanDataGridViewTextBoxColumn.HeaderText = "giaban";
            this.giabanDataGridViewTextBoxColumn.Name = "giabanDataGridViewTextBoxColumn";
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn.HeaderText = "MaHang";
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 379);
            this.Controls.Add(this.cbohang);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtmau);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butreset);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butnhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvsanpham);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHADODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHADODataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butnhap;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butreset;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmau;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.ComboBox cbohang;
        private QLBHADODataSet qLBHADODataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private QLBHADODataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        
        private System.Windows.Forms.BindingSource hangSXBindingSource;
        private QLBHADODataSet1 qLBHADODataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private QLBHADODataSet1TableAdapters.HangSXTableAdapter hangSXTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mausacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
    }
}

