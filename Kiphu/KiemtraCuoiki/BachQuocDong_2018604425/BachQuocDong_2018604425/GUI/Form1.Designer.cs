
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvhang = new System.Windows.Forms.DataGridView();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.butthem = new System.Windows.Forms.Button();
            this.buttim = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.cboloai = new System.Windows.Forms.ComboBox();
            this.Mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại hàng";
            // 
            // dgvhang
            // 
            this.dgvhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahang,
            this.Tenhang,
            this.Dongia,
            this.Tenloai});
            this.dgvhang.Location = new System.Drawing.Point(35, 233);
            this.dgvhang.Name = "dgvhang";
            this.dgvhang.Size = new System.Drawing.Size(614, 114);
            this.dgvhang.TabIndex = 6;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(157, 75);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 8;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(157, 35);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 9;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(157, 115);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(100, 20);
            this.txtgia.TabIndex = 10;
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(547, 48);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 11;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // buttim
            // 
            this.buttim.Location = new System.Drawing.Point(547, 115);
            this.buttim.Name = "buttim";
            this.buttim.Size = new System.Drawing.Size(75, 23);
            this.buttim.TabIndex = 12;
            this.buttim.Text = "Tim";
            this.buttim.UseVisualStyleBackColor = true;
            this.buttim.Click += new System.EventHandler(this.buttim_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(547, 186);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 14;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // cboloai
            // 
            this.cboloai.FormattingEnabled = true;
            this.cboloai.Location = new System.Drawing.Point(157, 153);
            this.cboloai.Name = "cboloai";
            this.cboloai.Size = new System.Drawing.Size(121, 21);
            this.cboloai.TabIndex = 15;
            // 
            // Mahang
            // 
            this.Mahang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mahang.DataPropertyName = "Mahang";
            this.Mahang.HeaderText = "Mã Hàng";
            this.Mahang.Name = "Mahang";
            // 
            // Tenhang
            // 
            this.Tenhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenhang.DataPropertyName = "Tenhang";
            this.Tenhang.HeaderText = "Tên Hàng";
            this.Tenhang.Name = "Tenhang";
            // 
            // Dongia
            // 
            this.Dongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dongia.DataPropertyName = "Dongia";
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.Name = "Dongia";
            // 
            // Tenloai
            // 
            this.Tenloai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenloai.DataPropertyName = "Tenloai";
            this.Tenloai.HeaderText = "Tên loại";
            this.Tenloai.Name = "Tenloai";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 368);
            this.Controls.Add(this.cboloai);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.buttim);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.dgvhang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvhang;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button buttim;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.ComboBox cboloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloai;
    }
}

