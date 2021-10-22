
namespace QLVSVIP
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
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.cbokhoa = new System.Windows.Forms.ComboBox();
            this.dateTimengaysinh = new System.Windows.Forms.DateTimePicker();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.butthem = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butreset = new System.Windows.Forms.Button();
            this.buttim = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.dgvsinhvien = new System.Windows.Forms.DataGridView();
            this.txtseach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(57, 33);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 0;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(57, 79);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 1;
            // 
            // txtdiem
            // 
            this.txtdiem.Location = new System.Drawing.Point(57, 177);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(100, 20);
            this.txtdiem.TabIndex = 2;
            // 
            // cbokhoa
            // 
            this.cbokhoa.FormattingEnabled = true;
            this.cbokhoa.Location = new System.Drawing.Point(57, 203);
            this.cbokhoa.Name = "cbokhoa";
            this.cbokhoa.Size = new System.Drawing.Size(121, 21);
            this.cbokhoa.TabIndex = 3;
            // 
            // dateTimengaysinh
            // 
            this.dateTimengaysinh.CustomFormat = "MM /dd/yyyy";
            this.dateTimengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimengaysinh.Location = new System.Drawing.Point(57, 117);
            this.dateTimengaysinh.Name = "dateTimengaysinh";
            this.dateTimengaysinh.Size = new System.Drawing.Size(121, 20);
            this.dateTimengaysinh.TabIndex = 4;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(57, 144);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(47, 17);
            this.radnam.TabIndex = 5;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(118, 144);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(39, 17);
            this.radnu.TabIndex = 6;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nu";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(384, 33);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 7;
            this.butthem.Text = "Nhập";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(493, 31);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 8;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(384, 79);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 9;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butreset
            // 
            this.butreset.Location = new System.Drawing.Point(493, 78);
            this.butreset.Name = "butreset";
            this.butreset.Size = new System.Drawing.Size(75, 23);
            this.butreset.TabIndex = 10;
            this.butreset.Text = "Reset";
            this.butreset.UseVisualStyleBackColor = true;
            this.butreset.Click += new System.EventHandler(this.butreset_Click);
            // 
            // buttim
            // 
            this.buttim.Location = new System.Drawing.Point(493, 113);
            this.buttim.Name = "buttim";
            this.buttim.Size = new System.Drawing.Size(75, 23);
            this.buttim.TabIndex = 11;
            this.buttim.Text = "Tìm kiếm";
            this.buttim.UseVisualStyleBackColor = true;
            this.buttim.Click += new System.EventHandler(this.buttim_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(493, 155);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 12;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // dgvsinhvien
            // 
            this.dgvsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsinhvien.Location = new System.Drawing.Point(57, 230);
            this.dgvsinhvien.Name = "dgvsinhvien";
            this.dgvsinhvien.Size = new System.Drawing.Size(697, 236);
            this.dgvsinhvien.TabIndex = 13;
            this.dgvsinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsinhvien_CellClick);
            // 
            // txtseach
            // 
            this.txtseach.Location = new System.Drawing.Point(384, 116);
            this.txtseach.Name = "txtseach";
            this.txtseach.Size = new System.Drawing.Size(100, 20);
            this.txtseach.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 478);
            this.Controls.Add(this.txtseach);
            this.Controls.Add(this.dgvsinhvien);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.buttim);
            this.Controls.Add(this.butreset);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.radnu);
            this.Controls.Add(this.radnam);
            this.Controls.Add(this.dateTimengaysinh);
            this.Controls.Add(this.cbokhoa);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.ComboBox cbokhoa;
        private System.Windows.Forms.DateTimePicker dateTimengaysinh;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butreset;
        private System.Windows.Forms.Button buttim;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.DataGridView dgvsinhvien;
        private System.Windows.Forms.TextBox txtseach;
    }
}

