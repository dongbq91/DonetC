namespace Form_CHMT
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboloai = new System.Windows.Forms.ComboBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butnhap = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.qLMTDataSet = new Form_CHMT.QLMTDataSet();
            this.loaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiTableAdapter = new Form_CHMT.QLMTDataSetTableAdapters.LoaiTableAdapter();
            this.qLMTDataSet1 = new Form_CHMT.QLMTDataSet1();
            this.hangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangTableAdapter = new Form_CHMT.QLMTDataSet1TableAdapters.HangTableAdapter();
            this.qLMTDataSet2 = new Form_CHMT.QLMTDataSet2();
            this.loaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loaiTableAdapter1 = new Form_CHMT.QLMTDataSet2TableAdapters.LoaiTableAdapter();
            this.mahangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chủng loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày nhập kho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng còn ";
            // 
            // cboloai
            // 
            this.cboloai.DataSource = this.loaiBindingSource1;
            this.cboloai.DisplayMember = "tenloai";
            this.cboloai.FormattingEnabled = true;
            this.cboloai.Location = new System.Drawing.Point(132, 39);
            this.cboloai.Name = "cboloai";
            this.cboloai.Size = new System.Drawing.Size(193, 21);
            this.cboloai.TabIndex = 6;
            this.cboloai.ValueMember = "maloai";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(132, 81);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 7;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(132, 123);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 8;
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(132, 155);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(100, 20);
            this.txtNSX.TabIndex = 9;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(132, 223);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 10;
            // 
            // dateTime1
            // 
            this.dateTime1.CausesValidation = false;
            this.dateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime1.Location = new System.Drawing.Point(132, 183);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(200, 20);
            this.dateTime1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahangDataGridViewTextBoxColumn,
            this.tenhangDataGridViewTextBoxColumn,
            this.nhasxDataGridViewTextBoxColumn,
            this.ngaynhapDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.maloaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 167);
            this.dataGridView1.TabIndex = 12;
            // 
            // butnhap
            // 
            this.butnhap.Location = new System.Drawing.Point(530, 36);
            this.butnhap.Name = "butnhap";
            this.butnhap.Size = new System.Drawing.Size(75, 23);
            this.butnhap.TabIndex = 13;
            this.butnhap.Text = "Nhập mới";
            this.butnhap.UseVisualStyleBackColor = true;
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(530, 102);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 14;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(530, 151);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 15;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            // 
            // qLMTDataSet
            // 
            this.qLMTDataSet.DataSetName = "QLMTDataSet";
            this.qLMTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiBindingSource
            // 
            this.loaiBindingSource.DataMember = "Loai";
            this.loaiBindingSource.DataSource = this.qLMTDataSet;
            // 
            // loaiTableAdapter
            // 
            this.loaiTableAdapter.ClearBeforeFill = true;
            // 
            // qLMTDataSet1
            // 
            this.qLMTDataSet1.DataSetName = "QLMTDataSet1";
            this.qLMTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangBindingSource
            // 
            this.hangBindingSource.DataMember = "Hang";
            this.hangBindingSource.DataSource = this.qLMTDataSet1;
            // 
            // hangTableAdapter
            // 
            this.hangTableAdapter.ClearBeforeFill = true;
            // 
            // qLMTDataSet2
            // 
            this.qLMTDataSet2.DataSetName = "QLMTDataSet2";
            this.qLMTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiBindingSource1
            // 
            this.loaiBindingSource1.DataMember = "Loai";
            this.loaiBindingSource1.DataSource = this.qLMTDataSet2;
            // 
            // loaiTableAdapter1
            // 
            this.loaiTableAdapter1.ClearBeforeFill = true;
            // 
            // mahangDataGridViewTextBoxColumn
            // 
            this.mahangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahangDataGridViewTextBoxColumn.DataPropertyName = "mahang";
            this.mahangDataGridViewTextBoxColumn.HeaderText = "Mã Hàng";
            this.mahangDataGridViewTextBoxColumn.Name = "mahangDataGridViewTextBoxColumn";
            // 
            // tenhangDataGridViewTextBoxColumn
            // 
            this.tenhangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenhangDataGridViewTextBoxColumn.DataPropertyName = "tenhang";
            this.tenhangDataGridViewTextBoxColumn.HeaderText = "Tên Hàng";
            this.tenhangDataGridViewTextBoxColumn.Name = "tenhangDataGridViewTextBoxColumn";
            // 
            // nhasxDataGridViewTextBoxColumn
            // 
            this.nhasxDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nhasxDataGridViewTextBoxColumn.DataPropertyName = "nhasx";
            this.nhasxDataGridViewTextBoxColumn.HeaderText = "Nhà Sản Xuất";
            this.nhasxDataGridViewTextBoxColumn.Name = "nhasxDataGridViewTextBoxColumn";
            // 
            // ngaynhapDataGridViewTextBoxColumn
            // 
            this.ngaynhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaynhapDataGridViewTextBoxColumn.DataPropertyName = "ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.ngaynhapDataGridViewTextBoxColumn.Name = "ngaynhapDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // maloaiDataGridViewTextBoxColumn
            // 
            this.maloaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maloaiDataGridViewTextBoxColumn.DataPropertyName = "maloai";
            this.maloaiDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            this.maloaiDataGridViewTextBoxColumn.Name = "maloaiDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butnhap);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtNSX);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.cboloai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiBindingSource1)).EndInit();
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
        private System.Windows.Forms.ComboBox cboloai;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butnhap;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butthoat;
        private QLMTDataSet qLMTDataSet;
        private System.Windows.Forms.BindingSource loaiBindingSource;
        private QLMTDataSetTableAdapters.LoaiTableAdapter loaiTableAdapter;
        private QLMTDataSet1 qLMTDataSet1;
        private System.Windows.Forms.BindingSource hangBindingSource;
        private QLMTDataSet1TableAdapters.HangTableAdapter hangTableAdapter;
        private QLMTDataSet2 qLMTDataSet2;
        private System.Windows.Forms.BindingSource loaiBindingSource1;
        private QLMTDataSet2TableAdapters.LoaiTableAdapter loaiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaiDataGridViewTextBoxColumn;
    }
}

