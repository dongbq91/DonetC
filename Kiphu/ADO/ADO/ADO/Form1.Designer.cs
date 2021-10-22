
namespace ADO
{
    partial class form1
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
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet1 = new ADO.QLNSDataSet1();
            this.z = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.cbotenPB = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet = new ADO.QLNSDataSet();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.butthem = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butreset = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.qLBHDataSet = new ADO.QLBHDataSet();
            this.qLBHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new ADO.QLNSDataSetTableAdapters.DepartmentsTableAdapter();
            this.employeesTableAdapter = new ADO.QLNSDataSet1TableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet1)).BeginInit();
            this.z.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.AutoGenerateColumns = false;
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvnhanvien.DataSource = this.employeesBindingSource;
            this.dgvnhanvien.Location = new System.Drawing.Point(12, 243);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.Size = new System.Drawing.Size(543, 138);
            this.dgvnhanvien.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "fullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.qLNSDataSet1;
            // 
            // qLNSDataSet1
            // 
            this.qLNSDataSet1.DataSetName = "QLNSDataSet1";
            this.qLNSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // z
            // 
            this.z.Controls.Add(this.dateTimePicker1);
            this.z.Controls.Add(this.radNu);
            this.z.Controls.Add(this.radNam);
            this.z.Controls.Add(this.cbotenPB);
            this.z.Controls.Add(this.txtdiachi);
            this.z.Controls.Add(this.txtten);
            this.z.Controls.Add(this.label6);
            this.z.Controls.Add(this.label5);
            this.z.Controls.Add(this.label4);
            this.z.Controls.Add(this.label3);
            this.z.Controls.Add(this.label2);
            this.z.Controls.Add(this.label1);
            this.z.Controls.Add(this.txtMaNV);
            this.z.Location = new System.Drawing.Point(12, 23);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(430, 194);
            this.z.TabIndex = 1;
            this.z.TabStop = false;
            this.z.Text = "Thông tin NV";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(213, 117);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 11;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(121, 118);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 10;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // cbotenPB
            // 
            this.cbotenPB.DataSource = this.departmentsBindingSource;
            this.cbotenPB.DisplayMember = "DepartmentName";
            this.cbotenPB.FormattingEnabled = true;
            this.cbotenPB.Location = new System.Drawing.Point(121, 59);
            this.cbotenPB.Name = "cbotenPB";
            this.cbotenPB.Size = new System.Drawing.Size(143, 21);
            this.cbotenPB.TabIndex = 9;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.qLNSDataSet;
            // 
            // qLNSDataSet
            // 
            this.qLNSDataSet.DataSetName = "QLNSDataSet";
            this.qLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(121, 168);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(100, 20);
            this.txtdiachi.TabIndex = 8;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(121, 90);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đại chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đầy đủ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(121, 21);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(482, 44);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 2;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(482, 79);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 3;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(482, 109);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 4;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            // 
            // butreset
            // 
            this.butreset.Location = new System.Drawing.Point(482, 141);
            this.butreset.Name = "butreset";
            this.butreset.Size = new System.Drawing.Size(75, 23);
            this.butreset.TabIndex = 5;
            this.butreset.Text = "Reset";
            this.butreset.UseVisualStyleBackColor = true;
            this.butreset.Click += new System.EventHandler(this.butreset_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(482, 198);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 6;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBHDataSetBindingSource
            // 
            this.qLBHDataSetBindingSource.DataSource = this.qLBHDataSet;
            this.qLBHDataSetBindingSource.Position = 0;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 393);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butreset);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.z);
            this.Controls.Add(this.dgvnhanvien);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet1)).EndInit();
            this.z.ResumeLayout(false);
            this.z.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.GroupBox z;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.ComboBox cbotenPB;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butreset;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.BindingSource qLBHDataSetBindingSource;
        private QLBHDataSet qLBHDataSet;
        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private QLNSDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private QLNSDataSet1 qLNSDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private QLNSDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}

