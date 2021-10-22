
namespace VD4._3_Doichu
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
            this.txthoten = new System.Windows.Forms.TextBox();
            this.butxoa = new System.Windows.Forms.Button();
            this.butkq = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.radthuong = new System.Windows.Forms.RadioButton();
            this.radhoa = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên vào đê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn kiểu chữ đê";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(134, 27);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(220, 20);
            this.txthoten.TabIndex = 4;
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(308, 103);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(53, 22);
            this.butxoa.TabIndex = 5;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butkq
            // 
            this.butkq.Location = new System.Drawing.Point(23, 147);
            this.butkq.Name = "butkq";
            this.butkq.Size = new System.Drawing.Size(68, 35);
            this.butkq.TabIndex = 6;
            this.butkq.Text = "Kết quả";
            this.butkq.UseVisualStyleBackColor = true;
            this.butkq.Click += new System.EventHandler(this.butkq_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(111, 155);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(220, 20);
            this.txtkq.TabIndex = 7;
            // 
            // radthuong
            // 
            this.radthuong.AutoSize = true;
            this.radthuong.Location = new System.Drawing.Point(31, 103);
            this.radthuong.Name = "radthuong";
            this.radthuong.Size = new System.Drawing.Size(80, 17);
            this.radthuong.TabIndex = 8;
            this.radthuong.TabStop = true;
            this.radthuong.Text = "Chữ thường";
            this.radthuong.UseVisualStyleBackColor = true;
            // 
            // radhoa
            // 
            this.radhoa.AutoSize = true;
            this.radhoa.Location = new System.Drawing.Point(134, 103);
            this.radhoa.Name = "radhoa";
            this.radhoa.Size = new System.Drawing.Size(65, 17);
            this.radhoa.TabIndex = 9;
            this.radhoa.TabStop = true;
            this.radhoa.Text = "Chữ hoa";
            this.radhoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 209);
            this.Controls.Add(this.radhoa);
            this.Controls.Add(this.radthuong);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.butkq);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butkq;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.RadioButton radthuong;
        private System.Windows.Forms.RadioButton radhoa;
    }
}

