namespace QLTV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.qLTVDataSet = new QLTV.QLTVDataSet();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btsua = new System.Windows.Forms.Button();
            this.txtsotrang = new System.Windows.Forms.TextBox();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnhapmoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btthoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTheLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLTVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.sachTableAdapter = new QLTV.QLTVDataSetTableAdapters.SachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // txtmasach
            // 
            this.txtmasach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qLTVDataSet, "Sach.MaSach", true));
            this.txtmasach.Location = new System.Drawing.Point(181, 39);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(194, 22);
            this.txtmasach.TabIndex = 1;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(448, 38);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(90, 30);
            this.btthem.TabIndex = 2;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(448, 95);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(90, 30);
            this.btxoa.TabIndex = 5;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Sách";
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(448, 155);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(90, 30);
            this.btsua.TabIndex = 8;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // txtsotrang
            // 
            this.txtsotrang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sachBindingSource, "SoTrang", true));
            this.txtsotrang.Location = new System.Drawing.Point(181, 156);
            this.txtsotrang.Name = "txtsotrang";
            this.txtsotrang.Size = new System.Drawing.Size(194, 22);
            this.txtsotrang.TabIndex = 7;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.qLTVDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số Trang";
            // 
            // btnhapmoi
            // 
            this.btnhapmoi.Location = new System.Drawing.Point(448, 212);
            this.btnhapmoi.Name = "btnhapmoi";
            this.btnhapmoi.Size = new System.Drawing.Size(90, 33);
            this.btnhapmoi.TabIndex = 11;
            this.btnhapmoi.Text = "Nhập Mới";
            this.btnhapmoi.UseVisualStyleBackColor = true;
            this.btnhapmoi.Click += new System.EventHandler(this.btnhapmoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thể loại";
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(588, 38);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(82, 30);
            this.btthoat.TabIndex = 14;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.soTrangDataGridViewTextBoxColumn,
            this.maTheLoaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Sach";
            this.dataGridView1.DataSource = this.qLTVDataSetBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 184);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "Mã Sách";
            this.maSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "Tên Sách";
            this.tenSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            // 
            // soTrangDataGridViewTextBoxColumn
            // 
            this.soTrangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soTrangDataGridViewTextBoxColumn.DataPropertyName = "SoTrang";
            this.soTrangDataGridViewTextBoxColumn.HeaderText = "Số Trang";
            this.soTrangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTrangDataGridViewTextBoxColumn.Name = "soTrangDataGridViewTextBoxColumn";
            // 
            // maTheLoaiDataGridViewTextBoxColumn
            // 
            this.maTheLoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maTheLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaTheLoai";
            this.maTheLoaiDataGridViewTextBoxColumn.HeaderText = "Mã Thể Loại";
            this.maTheLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTheLoaiDataGridViewTextBoxColumn.Name = "maTheLoaiDataGridViewTextBoxColumn";
            // 
            // qLTVDataSetBindingSource
            // 
            this.qLTVDataSetBindingSource.DataSource = this.qLTVDataSet;
            this.qLTVDataSetBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // txttensach
            // 
            this.txttensach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sachBindingSource, "TenSach", true));
            this.txttensach.Location = new System.Drawing.Point(181, 96);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(194, 22);
            this.txttensach.TabIndex = 4;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btnhapmoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.txtsotrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.TextBox txtsotrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnhapmoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource qLTVDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTheLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QLTVDataSetTableAdapters.SachTableAdapter sachTableAdapter;
    }
}

