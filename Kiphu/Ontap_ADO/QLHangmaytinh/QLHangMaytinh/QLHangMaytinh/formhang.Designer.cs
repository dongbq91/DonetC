
namespace QLHangMaytinh
{
    partial class formhang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLHMTDataSet4 = new QLHangMaytinh.QLHMTDataSet4();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHMTDataSet3 = new QLHangMaytinh.QLHMTDataSet3();
            this.cboloai = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHMTDataSet = new QLHangMaytinh.QLHMTDataSet();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtnsx = new System.Windows.Forms.TextBox();
            this.txtslc = new System.Windows.Forms.TextBox();
            this.butnhap = new System.Windows.Forms.Button();
            this.butxua = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.buttim = new System.Windows.Forms.Button();
            this.categoryTableAdapter = new QLHangMaytinh.QLHMTDataSetTableAdapters.CategoryTableAdapter();
            this.butreset = new System.Windows.Forms.Button();
            this.productTableAdapter = new QLHangMaytinh.QLHMTDataSet3TableAdapters.ProductTableAdapter();
            this.productTableAdapter1 = new QLHangMaytinh.QLHMTDataSet4TableAdapters.ProductTableAdapter();
            this.datetimepick = new System.Windows.Forms.DateTimePicker();
            this.qLHMTDataSet5 = new QLHangMaytinh.QLHMTDataSet5();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter2 = new QLHangMaytinh.QLHMTDataSet5TableAdapters.ProductTableAdapter();
            this.dgvhang = new System.Windows.Forms.DataGridView();
            this.mahangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slconDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasanxuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.qLHMTDataSet6 = new QLHangMaytinh.QLHMTDataSet6();
            this.productTableAdapter3 = new QLHangMaytinh.QLHMTDataSet6TableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHMTDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHMTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHMTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHMTDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHMTDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chủng loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ma Hang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ten Hang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhà sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngay Nhap kho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "So luong con";
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.qLHMTDataSet4;
            // 
            // qLHMTDataSet4
            // 
            this.qLHMTDataSet4.DataSetName = "QLHMTDataSet4";
            this.qLHMTDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.qLHMTDataSet3;
            // 
            // qLHMTDataSet3
            // 
            this.qLHMTDataSet3.DataSetName = "QLHMTDataSet3";
            this.qLHMTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboloai
            // 
            this.cboloai.DataSource = this.categoryBindingSource;
            this.cboloai.DisplayMember = "Tenloai";
            this.cboloai.FormattingEnabled = true;
            this.cboloai.Location = new System.Drawing.Point(153, 54);
            this.cboloai.Name = "cboloai";
            this.cboloai.Size = new System.Drawing.Size(121, 21);
            this.cboloai.TabIndex = 8;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.qLHMTDataSet;
            // 
            // qLHMTDataSet
            // 
            this.qLHMTDataSet.DataSetName = "QLHMTDataSet";
            this.qLHMTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(153, 92);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(100, 20);
            this.txtmahang.TabIndex = 9;
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(153, 136);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(100, 20);
            this.txttenhang.TabIndex = 10;
            // 
            // txtnsx
            // 
            this.txtnsx.Location = new System.Drawing.Point(153, 171);
            this.txtnsx.Name = "txtnsx";
            this.txtnsx.Size = new System.Drawing.Size(100, 20);
            this.txtnsx.TabIndex = 11;
            // 
            // txtslc
            // 
            this.txtslc.Location = new System.Drawing.Point(153, 251);
            this.txtslc.Name = "txtslc";
            this.txtslc.Size = new System.Drawing.Size(100, 20);
            this.txtslc.TabIndex = 12;
            // 
            // butnhap
            // 
            this.butnhap.Location = new System.Drawing.Point(476, 43);
            this.butnhap.Name = "butnhap";
            this.butnhap.Size = new System.Drawing.Size(75, 23);
            this.butnhap.TabIndex = 14;
            this.butnhap.Text = "Nhập";
            this.butnhap.UseVisualStyleBackColor = true;
            this.butnhap.Click += new System.EventHandler(this.butnhap_Click);
            // 
            // butxua
            // 
            this.butxua.Location = new System.Drawing.Point(476, 82);
            this.butxua.Name = "butxua";
            this.butxua.Size = new System.Drawing.Size(75, 23);
            this.butxua.TabIndex = 15;
            this.butxua.Text = "Sửa";
            this.butxua.UseVisualStyleBackColor = true;
            this.butxua.Click += new System.EventHandler(this.butxua_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(476, 126);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 16;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(476, 241);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 17;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // buttim
            // 
            this.buttim.Location = new System.Drawing.Point(475, 161);
            this.buttim.Name = "buttim";
            this.buttim.Size = new System.Drawing.Size(75, 23);
            this.buttim.TabIndex = 18;
            this.buttim.Text = "Tìm kiếm";
            this.buttim.UseVisualStyleBackColor = true;
            this.buttim.Click += new System.EventHandler(this.buttim_Click);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // butreset
            // 
            this.butreset.Location = new System.Drawing.Point(476, 201);
            this.butreset.Name = "butreset";
            this.butreset.Size = new System.Drawing.Size(75, 23);
            this.butreset.TabIndex = 19;
            this.butreset.Text = "Reset";
            this.butreset.UseVisualStyleBackColor = true;
            this.butreset.Click += new System.EventHandler(this.butreset_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // datetimepick
            // 
            this.datetimepick.CustomFormat = "MM / dd / yyyyy";
            this.datetimepick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepick.Location = new System.Drawing.Point(153, 214);
            this.datetimepick.Name = "datetimepick";
            this.datetimepick.Size = new System.Drawing.Size(121, 20);
            this.datetimepick.TabIndex = 20;
            // 
            // qLHMTDataSet5
            // 
            this.qLHMTDataSet5.DataSetName = "QLHMTDataSet5";
            this.qLHMTDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            this.productBindingSource2.DataSource = this.qLHMTDataSet5;
            // 
            // productTableAdapter2
            // 
            this.productTableAdapter2.ClearBeforeFill = true;
            // 
            // dgvhang
            // 
            this.dgvhang.AutoGenerateColumns = false;
            this.dgvhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahangDataGridViewTextBoxColumn,
            this.tenhangDataGridViewTextBoxColumn,
            this.slconDataGridViewTextBoxColumn,
            this.nhasanxuatDataGridViewTextBoxColumn,
            this.ngaynhapDataGridViewTextBoxColumn});
            this.dgvhang.DataSource = this.productBindingSource3;
            this.dgvhang.Location = new System.Drawing.Point(51, 277);
            this.dgvhang.Name = "dgvhang";
            this.dgvhang.Size = new System.Drawing.Size(540, 150);
            this.dgvhang.TabIndex = 21;
            this.dgvhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhang_CellClick);
            // 
            // mahangDataGridViewTextBoxColumn
            // 
            this.mahangDataGridViewTextBoxColumn.DataPropertyName = "Mahang";
            this.mahangDataGridViewTextBoxColumn.HeaderText = "Mahang";
            this.mahangDataGridViewTextBoxColumn.Name = "mahangDataGridViewTextBoxColumn";
            // 
            // tenhangDataGridViewTextBoxColumn
            // 
            this.tenhangDataGridViewTextBoxColumn.DataPropertyName = "Tenhang";
            this.tenhangDataGridViewTextBoxColumn.HeaderText = "Tenhang";
            this.tenhangDataGridViewTextBoxColumn.Name = "tenhangDataGridViewTextBoxColumn";
            // 
            // slconDataGridViewTextBoxColumn
            // 
            this.slconDataGridViewTextBoxColumn.DataPropertyName = "slcon";
            this.slconDataGridViewTextBoxColumn.HeaderText = "slcon";
            this.slconDataGridViewTextBoxColumn.Name = "slconDataGridViewTextBoxColumn";
            // 
            // nhasanxuatDataGridViewTextBoxColumn
            // 
            this.nhasanxuatDataGridViewTextBoxColumn.DataPropertyName = "Nhasanxuat";
            this.nhasanxuatDataGridViewTextBoxColumn.HeaderText = "Nhasanxuat";
            this.nhasanxuatDataGridViewTextBoxColumn.Name = "nhasanxuatDataGridViewTextBoxColumn";
            // 
            // ngaynhapDataGridViewTextBoxColumn
            // 
            this.ngaynhapDataGridViewTextBoxColumn.DataPropertyName = "Ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.HeaderText = "Ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.Name = "ngaynhapDataGridViewTextBoxColumn";
            // 
            // productBindingSource3
            // 
            this.productBindingSource3.DataMember = "Product";
            this.productBindingSource3.DataSource = this.qLHMTDataSet6;
            // 
            // qLHMTDataSet6
            // 
            this.qLHMTDataSet6.DataSetName = "QLHMTDataSet6";
            this.qLHMTDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter3
            // 
            this.productTableAdapter3.ClearBeforeFill = true;
            // 
            // formhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 438);
            this.Controls.Add(this.dgvhang);
            this.Controls.Add(this.datetimepick);
            this.Controls.Add(this.butreset);
            this.Controls.Add(this.buttim);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butxua);
            this.Controls.Add(this.butnhap);
            this.Controls.Add(this.txtslc);
            this.Controls.Add(this.txtnsx);
            this.Controls.Add(this.txttenhang);
            this.Controls.Add(this.txtmahang);
            this.Controls.Add(this.cboloai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formhang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHMTDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHMTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHMTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHMTDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHMTDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboloai;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtnsx;
        private System.Windows.Forms.TextBox txtslc;
        private System.Windows.Forms.Button butnhap;
        private System.Windows.Forms.Button butxua;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button buttim;
        private QLHMTDataSet qLHMTDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private QLHMTDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button butreset;
        private QLHMTDataSet3 qLHMTDataSet3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private QLHMTDataSet3TableAdapters.ProductTableAdapter productTableAdapter;
        private QLHMTDataSet4 qLHMTDataSet4;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private QLHMTDataSet4TableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.DateTimePicker datetimepick;
        private QLHMTDataSet5 qLHMTDataSet5;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private QLHMTDataSet5TableAdapters.ProductTableAdapter productTableAdapter2;
        private System.Windows.Forms.DataGridView dgvhang;
        private QLHMTDataSet6 qLHMTDataSet6;
        private System.Windows.Forms.BindingSource productBindingSource3;
        private QLHMTDataSet6TableAdapters.ProductTableAdapter productTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slconDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasanxuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhapDataGridViewTextBoxColumn;
    }
}

