namespace BT_Form_ADO
{
    partial class BTSQL
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
            this.Gr1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.cbotenpb = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet1 = new BT_Form_ADO.QLNSDataSet1();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtho = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.Label();
            this.ngaysinh = new System.Windows.Forms.Label();
            this.gt = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.Label();
            this.ho = new System.Windows.Forms.Label();
            this.tenpb = new System.Windows.Forms.Label();
            this.manv = new System.Windows.Forms.Label();
            this.butthem = new System.Windows.Forms.Button();
            this.butedit = new System.Windows.Forms.Button();
            this.butdelete = new System.Windows.Forms.Button();
            this.butnhaptiep = new System.Windows.Forms.Button();
            this.butout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet = new BT_Form_ADO.QLNSDataSet();
            this.employessTableAdapter = new BT_Form_ADO.QLNSDataSetTableAdapters.EmployessTableAdapter();
            this.departmentsTableAdapter = new BT_Form_ADO.QLNSDataSet1TableAdapters.DepartmentsTableAdapter();
            this.Gr1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Gr1
            // 
            this.Gr1.Controls.Add(this.dateTimePicker1);
            this.Gr1.Controls.Add(this.radnu);
            this.Gr1.Controls.Add(this.radnam);
            this.Gr1.Controls.Add(this.cbotenpb);
            this.Gr1.Controls.Add(this.txtdiachi);
            this.Gr1.Controls.Add(this.txtfullname);
            this.Gr1.Controls.Add(this.txtten);
            this.Gr1.Controls.Add(this.txtho);
            this.Gr1.Controls.Add(this.txtmanv);
            this.Gr1.Controls.Add(this.diachi);
            this.Gr1.Controls.Add(this.ngaysinh);
            this.Gr1.Controls.Add(this.gt);
            this.Gr1.Controls.Add(this.fullname);
            this.Gr1.Controls.Add(this.ten);
            this.Gr1.Controls.Add(this.ho);
            this.Gr1.Controls.Add(this.tenpb);
            this.Gr1.Controls.Add(this.manv);
            this.Gr1.Location = new System.Drawing.Point(24, 12);
            this.Gr1.Name = "Gr1";
            this.Gr1.Size = new System.Drawing.Size(367, 269);
            this.Gr1.TabIndex = 0;
            this.Gr1.TabStop = false;
            this.Gr1.Text = "Thông tin nhân viên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(165, 172);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(39, 17);
            this.radnu.TabIndex = 15;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(112, 172);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(47, 17);
            this.radnam.TabIndex = 14;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // cbotenpb
            // 
            this.cbotenpb.DataSource = this.departmentsBindingSource;
            this.cbotenpb.DisplayMember = "Departmentname";
            this.cbotenpb.FormattingEnabled = true;
            this.cbotenpb.Location = new System.Drawing.Point(112, 50);
            this.cbotenpb.Name = "cbotenpb";
            this.cbotenpb.Size = new System.Drawing.Size(176, 21);
            this.cbotenpb.TabIndex = 13;
            this.cbotenpb.ValueMember = "DepartmentID";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.qLNSDataSet1;
            // 
            // qLNSDataSet1
            // 
            this.qLNSDataSet1.DataSetName = "QLNSDataSet1";
            this.qLNSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(112, 239);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(198, 20);
            this.txtdiachi.TabIndex = 12;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(112, 139);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(176, 20);
            this.txtfullname.TabIndex = 11;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(112, 111);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 10;
            // 
            // txtho
            // 
            this.txtho.Location = new System.Drawing.Point(112, 79);
            this.txtho.Name = "txtho";
            this.txtho.Size = new System.Drawing.Size(100, 20);
            this.txtho.TabIndex = 9;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(112, 20);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 20);
            this.txtmanv.TabIndex = 8;
            // 
            // diachi
            // 
            this.diachi.AutoSize = true;
            this.diachi.Location = new System.Drawing.Point(18, 239);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(40, 13);
            this.diachi.TabIndex = 7;
            this.diachi.Text = "Địa chỉ";
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSize = true;
            this.ngaysinh.Location = new System.Drawing.Point(16, 198);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(54, 13);
            this.ngaysinh.TabIndex = 6;
            this.ngaysinh.Text = "Ngày sinh";
            // 
            // gt
            // 
            this.gt.AutoSize = true;
            this.gt.Location = new System.Drawing.Point(15, 172);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(51, 13);
            this.gt.TabIndex = 5;
            this.gt.Text = "Giới Tính";
            // 
            // fullname
            // 
            this.fullname.AutoSize = true;
            this.fullname.Location = new System.Drawing.Point(15, 146);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(63, 13);
            this.fullname.TabIndex = 4;
            this.fullname.Text = "Tên đầy đủ";
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Location = new System.Drawing.Point(16, 116);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(26, 13);
            this.ten.TabIndex = 3;
            this.ten.Text = "Tên";
            // 
            // ho
            // 
            this.ho.AutoSize = true;
            this.ho.Location = new System.Drawing.Point(17, 83);
            this.ho.Name = "ho";
            this.ho.Size = new System.Drawing.Size(21, 13);
            this.ho.TabIndex = 2;
            this.ho.Text = "Họ";
            // 
            // tenpb
            // 
            this.tenpb.AutoSize = true;
            this.tenpb.Location = new System.Drawing.Point(16, 55);
            this.tenpb.Name = "tenpb";
            this.tenpb.Size = new System.Drawing.Size(82, 13);
            this.tenpb.TabIndex = 1;
            this.tenpb.Text = "Tên Phòng Ban";
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Location = new System.Drawing.Point(17, 27);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(75, 13);
            this.manv.TabIndex = 0;
            this.manv.Text = "Mã nhân viên ";
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(437, 39);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 1;
            this.butthem.Text = "Thêm mới";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butedit
            // 
            this.butedit.Location = new System.Drawing.Point(438, 73);
            this.butedit.Name = "butedit";
            this.butedit.Size = new System.Drawing.Size(75, 23);
            this.butedit.TabIndex = 2;
            this.butedit.Text = "Sửa";
            this.butedit.UseVisualStyleBackColor = true;
            // 
            // butdelete
            // 
            this.butdelete.Location = new System.Drawing.Point(437, 115);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(75, 23);
            this.butdelete.TabIndex = 3;
            this.butdelete.Text = "Xóa";
            this.butdelete.UseVisualStyleBackColor = true;
            // 
            // butnhaptiep
            // 
            this.butnhaptiep.Location = new System.Drawing.Point(437, 158);
            this.butnhaptiep.Name = "butnhaptiep";
            this.butnhaptiep.Size = new System.Drawing.Size(75, 23);
            this.butnhaptiep.TabIndex = 4;
            this.butnhaptiep.Text = "Nhập tiếp";
            this.butnhaptiep.UseVisualStyleBackColor = true;
            // 
            // butout
            // 
            this.butout.Location = new System.Drawing.Point(437, 241);
            this.butout.Name = "butout";
            this.butout.Size = new System.Drawing.Size(75, 23);
            this.butout.TabIndex = 5;
            this.butout.Text = "Thoát";
            this.butout.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employessBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Đông ăn Lồn";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // employessBindingSource
            // 
            this.employessBindingSource.DataMember = "Employess";
            this.employessBindingSource.DataSource = this.qLNSDataSet;
            // 
            // qLNSDataSet
            // 
            this.qLNSDataSet.DataSetName = "QLNSDataSet";
            this.qLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employessTableAdapter
            // 
            this.employessTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // BTSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butout);
            this.Controls.Add(this.butnhaptiep);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.butedit);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.Gr1);
            this.Name = "BTSQL";
            this.Text = "      ";
            this.Load += new System.EventHandler(this.BTSQL_Load);
            this.Gr1.ResumeLayout(false);
            this.Gr1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gr1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.ComboBox cbotenpb;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtho;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label diachi;
        private System.Windows.Forms.Label ngaysinh;
        private System.Windows.Forms.Label gt;
        private System.Windows.Forms.Label fullname;
        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.Label ho;
        private System.Windows.Forms.Label tenpb;
        private System.Windows.Forms.Label manv;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butedit;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Button butnhaptiep;
        private System.Windows.Forms.Button butout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource employessBindingSource;
        private QLNSDataSetTableAdapters.EmployessTableAdapter employessTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private QLNSDataSet1 qLNSDataSet1;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private QLNSDataSet1TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
    }
}

