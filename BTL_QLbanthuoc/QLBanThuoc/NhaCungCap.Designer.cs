namespace Login
{
    partial class NhaCungCap
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenNCC = new System.Windows.Forms.TextBox();
            this.txtmaNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butluu = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.buthem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSDTNCC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddNCC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttenNCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmaNCC);
            this.groupBox1.Location = new System.Drawing.Point(24, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 172);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Nhà Cung Cấp";
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
            // txtSDTNCC
            // 
            this.txtSDTNCC.Location = new System.Drawing.Point(157, 128);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(58, 20);
            this.txtSDTNCC.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Nhà Cung Cấp :";
            // 
            // txtAddNCC
            // 
            this.txtAddNCC.Location = new System.Drawing.Point(157, 89);
            this.txtAddNCC.Name = "txtAddNCC";
            this.txtAddNCC.Size = new System.Drawing.Size(100, 20);
            this.txtAddNCC.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Nhà Cung cấp :";
            // 
            // txttenNCC
            // 
            this.txttenNCC.Location = new System.Drawing.Point(157, 58);
            this.txttenNCC.Name = "txttenNCC";
            this.txttenNCC.Size = new System.Drawing.Size(148, 20);
            this.txttenNCC.TabIndex = 10;
            // 
            // txtmaNCC
            // 
            this.txtmaNCC.Location = new System.Drawing.Point(157, 26);
            this.txtmaNCC.Name = "txtmaNCC";
            this.txtmaNCC.Size = new System.Drawing.Size(100, 20);
            this.txtmaNCC.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa Chỉ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNCC);
            this.groupBox2.Location = new System.Drawing.Point(24, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 171);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Location = new System.Drawing.Point(7, 20);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.Size = new System.Drawing.Size(683, 145);
            this.dgvNCC.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Login.Properties.Resources.find__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(368, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Tìm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // butxoa
            // 
            this.butxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butxoa.Image = global::Login.Properties.Resources._3Xoa;
            this.butxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butxoa.Location = new System.Drawing.Point(286, 23);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(85, 39);
            this.butxoa.TabIndex = 17;
            this.butxoa.Text = "Xóa ";
            this.butxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butxoa.UseVisualStyleBackColor = true;
            // 
            // butluu
            // 
            this.butluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butluu.Image = global::Login.Properties.Resources.Luu;
            this.butluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butluu.Location = new System.Drawing.Point(128, 23);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(79, 39);
            this.butluu.TabIndex = 16;
            this.butluu.Text = "Lưu";
            this.butluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butluu.UseVisualStyleBackColor = true;
            // 
            // butsua
            // 
            this.butsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsua.Image = global::Login.Properties.Resources._2Sua;
            this.butsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butsua.Location = new System.Drawing.Point(204, 23);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(85, 39);
            this.butsua.TabIndex = 15;
            this.butsua.Text = "Sửa";
            this.butsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butsua.UseVisualStyleBackColor = true;
            // 
            // buthem
            // 
            this.buthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buthem.Image = global::Login.Properties.Resources._1Them;
            this.buthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buthem.Location = new System.Drawing.Point(12, 23);
            this.buthem.Name = "buthem";
            this.buthem.Size = new System.Drawing.Size(119, 39);
            this.buthem.TabIndex = 14;
            this.buthem.Text = "Thêm mới ";
            this.buthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buthem.UseVisualStyleBackColor = true;
            // 
            // NhaCungCap
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
            this.Name = "NhaCungCap";
            this.Text = "Nhà Cung Cấp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenNCC;
        private System.Windows.Forms.TextBox txtmaNCC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butluu;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button buthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNCC;
    }
}