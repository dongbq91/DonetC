namespace Test_4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buthem = new System.Windows.Forms.Button();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtsotrang = new System.Windows.Forms.TextBox();
            this.cbomatheloai = new System.Windows.Forms.ComboBox();
            this.qLsachDataSet = new Test_4.QLsachDataSet();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter = new Test_4.QLsachDataSetTableAdapters.SachTableAdapter();
            this.masachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matheloaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLsachDataSet1 = new Test_4.QLsachDataSet1();
            this.theloaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theloaiTableAdapter = new Test_4.QLsachDataSet1TableAdapters.TheloaiTableAdapter();
            this.butsua = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsachDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theloaiBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(104, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // buthem
            // 
            this.buthem.Location = new System.Drawing.Point(453, 31);
            this.buthem.Name = "buthem";
            this.buthem.Size = new System.Drawing.Size(75, 23);
            this.buthem.TabIndex = 5;
            this.buthem.Text = "Them";
            this.buthem.UseVisualStyleBackColor = true;
            this.buthem.Click += new System.EventHandler(this.buthem_Click);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(145, 23);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 6;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(145, 60);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 7;
            // 
            // txtsotrang
            // 
            this.txtsotrang.Location = new System.Drawing.Point(145, 105);
            this.txtsotrang.Name = "txtsotrang";
            this.txtsotrang.Size = new System.Drawing.Size(100, 20);
            this.txtsotrang.TabIndex = 8;
            // 
            // cbomatheloai
            // 
            this.cbomatheloai.DataSource = this.theloaiBindingSource;
            this.cbomatheloai.DisplayMember = "tentheloai";
            this.cbomatheloai.FormattingEnabled = true;
            this.cbomatheloai.Location = new System.Drawing.Point(145, 143);
            this.cbomatheloai.Name = "cbomatheloai";
            this.cbomatheloai.Size = new System.Drawing.Size(121, 21);
            this.cbomatheloai.TabIndex = 9;
            this.cbomatheloai.ValueMember = "matheloai";
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
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(453, 82);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 10;
            this.butsua.Text = "Sua";
            this.butsua.UseVisualStyleBackColor = true;
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(453, 130);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 11;
            this.butthoat.Text = "Thoat";
            this.butthoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.cbomatheloai);
            this.Controls.Add(this.txtsotrang);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.buthem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsachDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theloaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buthem;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtsotrang;
        private System.Windows.Forms.ComboBox cbomatheloai;
        private QLsachDataSet qLsachDataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QLsachDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matheloaiDataGridViewTextBoxColumn;
        private QLsachDataSet1 qLsachDataSet1;
        private System.Windows.Forms.BindingSource theloaiBindingSource;
        private QLsachDataSet1TableAdapters.TheloaiTableAdapter theloaiTableAdapter;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butthoat;
    }
}

