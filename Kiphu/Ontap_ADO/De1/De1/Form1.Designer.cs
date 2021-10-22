
namespace De1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboluuy = new System.Windows.Forms.ComboBox();
            this.dgvhang = new System.Windows.Forms.DataGridView();
            this.datepickngay = new System.Windows.Forms.DateTimePicker();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.butnhap = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // cboluuy
            // 
            this.cboluuy.FormattingEnabled = true;
            this.cboluuy.Items.AddRange(new object[] {
            "H1",
            "H2",
            "H3"});
            this.cboluuy.Location = new System.Drawing.Point(131, 103);
            this.cboluuy.Name = "cboluuy";
            this.cboluuy.Size = new System.Drawing.Size(121, 21);
            this.cboluuy.TabIndex = 5;
            // 
            // dgvhang
            // 
            this.dgvhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhang.Location = new System.Drawing.Point(29, 211);
            this.dgvhang.Name = "dgvhang";
            this.dgvhang.Size = new System.Drawing.Size(644, 109);
            this.dgvhang.TabIndex = 6;
            this.dgvhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhang_CellClick);
            // 
            // datepickngay
            // 
            this.datepickngay.CustomFormat = "MM/dd/yyyy";
            this.datepickngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepickngay.Location = new System.Drawing.Point(131, 146);
            this.datepickngay.Name = "datepickngay";
            this.datepickngay.Size = new System.Drawing.Size(121, 20);
            this.datepickngay.TabIndex = 7;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(131, 180);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(100, 20);
            this.txtsl.TabIndex = 8;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(131, 24);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 9;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(131, 65);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 10;
            // 
            // butnhap
            // 
            this.butnhap.Location = new System.Drawing.Point(563, 21);
            this.butnhap.Name = "butnhap";
            this.butnhap.Size = new System.Drawing.Size(75, 23);
            this.butnhap.TabIndex = 11;
            this.butnhap.Text = "Nhập";
            this.butnhap.UseVisualStyleBackColor = true;
            this.butnhap.Click += new System.EventHandler(this.butnhap_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(563, 62);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 12;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(563, 111);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 13;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(563, 153);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 14;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 341);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butnhap);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.datepickngay);
            this.Controls.Add(this.dgvhang);
            this.Controls.Add(this.cboluuy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboluuy;
        private System.Windows.Forms.DataGridView dgvhang;
        private System.Windows.Forms.DateTimePicker datepickngay;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button butnhap;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butthoat;
    }
}

