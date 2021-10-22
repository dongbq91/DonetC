namespace Test_1
{
    partial class Gui
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
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtNSS = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboChung = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLCHMTDataSet1 = new Test_1.QLCHMTDataSet1();
            this.chungloaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chungloaiTableAdapter = new Test_1.QLCHMTDataSet1TableAdapters.ChungloaiTableAdapter();
            this.qLCHMTDataSet2 = new Test_1.QLCHMTDataSet2();
            this.hangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangTableAdapter = new Test_1.QLCHMTDataSet2TableAdapters.HangTableAdapter();
            this.mahangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasanxuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chungloaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtma
            // 
            this.txtma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "mahang", true));
            this.txtma.Location = new System.Drawing.Point(109, 105);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 0;
            // 
            // txtten
            // 
            this.txtten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "tenhang", true));
            this.txtten.Location = new System.Drawing.Point(109, 146);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 1;
            // 
            // txtNSS
            // 
            this.txtNSS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "nhasanxuat", true));
            this.txtNSS.Location = new System.Drawing.Point(109, 183);
            this.txtNSS.Name = "txtNSS";
            this.txtNSS.Size = new System.Drawing.Size(100, 20);
            this.txtNSS.TabIndex = 2;
            // 
            // txtsl
            // 
            this.txtsl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "soluong", true));
            this.txtsl.Location = new System.Drawing.Point(109, 257);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(100, 20);
            this.txtsl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chủng loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhà Sản Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng còn";
            // 
            // cboChung
            // 
            this.cboChung.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chungloaiBindingSource, "tenchung", true));
            this.cboChung.DataSource = this.chungloaiBindingSource;
            this.cboChung.FormattingEnabled = true;
            this.cboChung.Location = new System.Drawing.Point(109, 61);
            this.cboChung.Name = "cboChung";
            this.cboChung.Size = new System.Drawing.Size(121, 21);
            this.cboChung.TabIndex = 9;
            this.cboChung.ValueMember = "machung";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "ngaynhap", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày nhập kho";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahangDataGridViewTextBoxColumn,
            this.tenhangDataGridViewTextBoxColumn,
            this.nhasanxuatDataGridViewTextBoxColumn,
            this.ngaynhapDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.machungDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // qLCHMTDataSet1
            // 
            this.qLCHMTDataSet1.DataSetName = "QLCHMTDataSet1";
            this.qLCHMTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chungloaiBindingSource
            // 
            this.chungloaiBindingSource.DataMember = "Chungloai";
            this.chungloaiBindingSource.DataSource = this.qLCHMTDataSet1;
            // 
            // chungloaiTableAdapter
            // 
            this.chungloaiTableAdapter.ClearBeforeFill = true;
            // 
            // qLCHMTDataSet2
            // 
            this.qLCHMTDataSet2.DataSetName = "QLCHMTDataSet2";
            this.qLCHMTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangBindingSource
            // 
            this.hangBindingSource.DataMember = "Hang";
            this.hangBindingSource.DataSource = this.qLCHMTDataSet2;
            // 
            // hangTableAdapter
            // 
            this.hangTableAdapter.ClearBeforeFill = true;
            // 
            // mahangDataGridViewTextBoxColumn
            // 
            this.mahangDataGridViewTextBoxColumn.DataPropertyName = "mahang";
            this.mahangDataGridViewTextBoxColumn.HeaderText = "Mã Hàng";
            this.mahangDataGridViewTextBoxColumn.Name = "mahangDataGridViewTextBoxColumn";
            // 
            // tenhangDataGridViewTextBoxColumn
            // 
            this.tenhangDataGridViewTextBoxColumn.DataPropertyName = "tenhang";
            this.tenhangDataGridViewTextBoxColumn.HeaderText = "Tên Hàng";
            this.tenhangDataGridViewTextBoxColumn.Name = "tenhangDataGridViewTextBoxColumn";
            // 
            // nhasanxuatDataGridViewTextBoxColumn
            // 
            this.nhasanxuatDataGridViewTextBoxColumn.DataPropertyName = "nhasanxuat";
            this.nhasanxuatDataGridViewTextBoxColumn.HeaderText = "Nhà sản xuất";
            this.nhasanxuatDataGridViewTextBoxColumn.Name = "nhasanxuatDataGridViewTextBoxColumn";
            // 
            // ngaynhapDataGridViewTextBoxColumn
            // 
            this.ngaynhapDataGridViewTextBoxColumn.DataPropertyName = "ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.HeaderText = "Ngày Nhập Kho";
            this.ngaynhapDataGridViewTextBoxColumn.Name = "ngaynhapDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số Lượng Còn";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // machungDataGridViewTextBoxColumn
            // 
            this.machungDataGridViewTextBoxColumn.DataPropertyName = "machung";
            this.machungDataGridViewTextBoxColumn.HeaderText = "Mã Chủng";
            this.machungDataGridViewTextBoxColumn.Name = "machungDataGridViewTextBoxColumn";
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(490, 58);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 13;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(490, 101);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 14;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(490, 153);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 15;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboChung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtNSS);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Name = "Gui";
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.Gui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chungloaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtNSS;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboChung;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLCHMTDataSet1 qLCHMTDataSet1;
        private System.Windows.Forms.BindingSource chungloaiBindingSource;
        private QLCHMTDataSet1TableAdapters.ChungloaiTableAdapter chungloaiTableAdapter;
        private QLCHMTDataSet2 qLCHMTDataSet2;
        private System.Windows.Forms.BindingSource hangBindingSource;
        private QLCHMTDataSet2TableAdapters.HangTableAdapter hangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasanxuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machungDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butthoat;
    }
}

