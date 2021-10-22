
namespace VD1_Login
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
            this.txtkq = new System.Windows.Forms.TextBox();
            this.lstweb = new System.Windows.Forms.ListBox();
            this.butok = new System.Windows.Forms.Button();
            this.butreset = new System.Windows.Forms.Button();
            this.cboweb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link web";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(195, 86);
            this.txtkq.MaxLength = 6000000;
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(200, 20);
            this.txtkq.TabIndex = 1;
            // 
            // lstweb
            // 
            this.lstweb.FormattingEnabled = true;
            this.lstweb.Location = new System.Drawing.Point(13, 54);
            this.lstweb.Name = "lstweb";
            this.lstweb.Size = new System.Drawing.Size(161, 82);
            this.lstweb.TabIndex = 2;
            // 
            // butok
            // 
            this.butok.Location = new System.Drawing.Point(31, 202);
            this.butok.Name = "butok";
            this.butok.Size = new System.Drawing.Size(75, 23);
            this.butok.TabIndex = 3;
            this.butok.Text = "Oke";
            this.butok.UseVisualStyleBackColor = true;
            this.butok.Click += new System.EventHandler(this.butok_Click);
            // 
            // butreset
            // 
            this.butreset.Location = new System.Drawing.Point(132, 202);
            this.butreset.Name = "butreset";
            this.butreset.Size = new System.Drawing.Size(75, 23);
            this.butreset.TabIndex = 4;
            this.butreset.Text = "Reset";
            this.butreset.UseVisualStyleBackColor = true;
            this.butreset.Click += new System.EventHandler(this.butreset_Click);
            // 
            // cboweb
            // 
            this.cboweb.FormattingEnabled = true;
            this.cboweb.Location = new System.Drawing.Point(12, 153);
            this.cboweb.Name = "cboweb";
            this.cboweb.Size = new System.Drawing.Size(162, 21);
            this.cboweb.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 292);
            this.Controls.Add(this.cboweb);
            this.Controls.Add(this.butreset);
            this.Controls.Add(this.butok);
            this.Controls.Add(this.lstweb);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form web link";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.ListBox lstweb;
        private System.Windows.Forms.Button butok;
        private System.Windows.Forms.Button butreset;
        private System.Windows.Forms.ComboBox cboweb;
    }
}

