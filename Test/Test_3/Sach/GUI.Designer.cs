namespace Sach
{
    partial class GUI
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
            this.cbotheloai = new System.Windows.Forms.ComboBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtsotrang = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLsachDataSet = new Sach.QLsachDataSet();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter = new Sach.QLsachDataSetTableAdapters.SachTableAdapter();
            this.masachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matheloaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butxoa = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.qLsachDataSet1 = new Sach.QLsachDataSet1();
            this.theloaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theloaiTableAdapter = new Sach.QLsachDataSet1TableAdapters.TheloaiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsachDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theloaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số trang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thể lại";
            // 
            // cbotheloai
            // 
            this.cbotheloai.DataSource = this.theloaiBindingSource;
            this.cbotheloai.DisplayMember = "tentheloai";
            this.cbotheloai.FormattingEnabled = true;
            this.cbotheloai.Location = new System.Drawing.Point(124, 119);
            this.cbotheloai.Name = "cbotheloai";
            this.cbotheloai.Size = new System.Drawing.Size(121, 21);
            this.cbotheloai.TabIndex = 4;
            this.cbotheloai.ValueMember = "matheloai";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(124, 25);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 5;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(124, 59);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 6;
            // 
            // txtsotrang
            // 
            this.txtsotrang.Location = new System.Drawing.Point(124, 90);
            this.txtsotrang.Name = "txtsotrang";
            this.txtsotrang.Size = new System.Drawing.Size(100, 20);
            this.txtsotrang.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masachDataGridViewTextBoxColumn,
            this.tensachDataGridViewTextBoxColumn,
            this.sotrangDataGridViewTextBoxColumn,
            this.matheloaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sachBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 152);
            this.dataGridView1.TabIndex = 8;
            // 
            // qLsachDataSet
            // 
            this.qLsachDataSet.DataSetName = "QLsachDataSet";
            this.qLsachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.qLsachDataSet;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // masachDataGridViewTextBoxColumn
            // 
            this.masachDataGridViewTextBoxColumn.DataPropertyName = "masach";
            this.masachDataGridViewTextBoxColumn.HeaderText = "masach";
            this.masachDataGridViewTextBoxColumn.Name = "masachDataGridViewTextBoxColumn";
            // 
            // tensachDataGridViewTextBoxColumn
            // 
            this.tensachDataGridViewTextBoxColumn.DataPropertyName = "tensach";
            this.tensachDataGridViewTextBoxColumn.HeaderText = "tensach";
            this.tensachDataGridViewTextBoxColumn.Name = "tensachDataGridViewTextBoxColumn";
            // 
            // sotrangDataGridViewTextBoxColumn
            // 
            this.sotrangDataGridViewTextBoxColumn.DataPropertyName = "sotrang";
            this.sotrangDataGridViewTextBoxColumn.HeaderText = "sotrang";
            this.sotrangDataGridViewTextBoxColumn.Name = "sotrangDataGridViewTextBoxColumn";
            // 
            // matheloaiDataGridViewTextBoxColumn
            // 
            this.matheloaiDataGridViewTextBoxColumn.DataPropertyName = "matheloai";
            this.matheloaiDataGridViewTextBoxColumn.HeaderText = "matheloai";
            this.matheloaiDataGridViewTextBoxColumn.Name = "matheloaiDataGridViewTextBoxColumn";
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(406, 25);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 9;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(406, 68);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 10;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(406, 108);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 11;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            // 
            // qLsachDataSet1
            // 
            this.qLsachDataSet1.DataSetName = "QLsachDataSet1";
            this.qLsachDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theloaiBindingSource
            // 
            this.theloaiBindingSource.DataMember = "Theloai";
            this.theloaiBindingSource.DataSource = this.qLsachDataSet1;
            // 
            // theloaiTableAdapter
            // 
            this.theloaiTableAdapter.ClearBeforeFill = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsotrang);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.cbotheloai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI";
            this.Text = "d";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsachDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theloaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbotheloai;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtsotrang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLsachDataSet qLsachDataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QLsachDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matheloaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butthoat;
        private QLsachDataSet1 qLsachDataSet1;
        private System.Windows.Forms.BindingSource theloaiBindingSource;
        private QLsachDataSet1TableAdapters.TheloaiTableAdapter theloaiTableAdapter;
    }
}

