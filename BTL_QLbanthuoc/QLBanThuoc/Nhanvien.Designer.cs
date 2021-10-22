namespace Login
{
    partial class Nhanvien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenNV = new System.Windows.Forms.TextBox();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butluu = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.buthem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSDTNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttenNV);
            this.groupBox1.Controls.Add(this.txtmaNV);
            this.groupBox1.Location = new System.Drawing.Point(40, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 172);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Địa chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại :";
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Location = new System.Drawing.Point(139, 128);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(58, 20);
            this.txtSDTNV.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Nhân Viên :";
            // 
            // txtAddNV
            // 
            this.txtAddNV.Location = new System.Drawing.Point(139, 93);
            this.txtAddNV.Name = "txtAddNV";
            this.txtAddNV.Size = new System.Drawing.Size(100, 20);
            this.txtAddNV.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Nhân Viên :";
            // 
            // txttenNV
            // 
            this.txttenNV.Location = new System.Drawing.Point(139, 54);
            this.txttenNV.Name = "txttenNV";
            this.txttenNV.Size = new System.Drawing.Size(148, 20);
            this.txttenNV.TabIndex = 10;
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(139, 19);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(100, 20);
            this.txtmaNV.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhanvien);
            this.groupBox2.Location = new System.Drawing.Point(40, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 161);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Location = new System.Drawing.Point(7, 20);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.Size = new System.Drawing.Size(665, 125);
            this.dgvNhanvien.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Login.Properties.Resources.find__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(368, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tìm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // butxoa
            // 
            this.butxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butxoa.Image = global::Login.Properties.Resources._3Xoa;
            this.butxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butxoa.Location = new System.Drawing.Point(286, 21);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(85, 39);
            this.butxoa.TabIndex = 11;
            this.butxoa.Text = "Xóa ";
            this.butxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butxoa.UseVisualStyleBackColor = true;
            // 
            // butluu
            // 
            this.butluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butluu.Image = global::Login.Properties.Resources.Luu;
            this.butluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butluu.Location = new System.Drawing.Point(128, 21);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(79, 39);
            this.butluu.TabIndex = 10;
            this.butluu.Text = "Lưu";
            this.butluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butluu.UseVisualStyleBackColor = true;
            // 
            // butsua
            // 
            this.butsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsua.Image = global::Login.Properties.Resources._2Sua;
            this.butsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butsua.Location = new System.Drawing.Point(204, 21);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(85, 39);
            this.butsua.TabIndex = 9;
            this.butsua.Text = "Sửa";
            this.butsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butsua.UseVisualStyleBackColor = true;
            // 
            // buthem
            // 
            this.buthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buthem.Image = global::Login.Properties.Resources._1Them;
            this.buthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buthem.Location = new System.Drawing.Point(12, 21);
            this.buthem.Name = "buthem";
            this.buthem.Size = new System.Drawing.Size(119, 39);
            this.buthem.TabIndex = 8;
            this.buthem.Text = "Thêm mới ";
            this.buthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buthem.UseVisualStyleBackColor = true;
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.buthem);
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butluu;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button buthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenNV;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhanvien;
    }
}