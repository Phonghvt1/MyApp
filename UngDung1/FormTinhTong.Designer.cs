﻿namespace UngDung1
{
    partial class FormTinhTong
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
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "So a";
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(188, 49);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(393, 20);
            this.txtSoa.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(188, 203);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(188, 98);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(393, 20);
            this.txtSob.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "So b";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(188, 153);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(393, 20);
            this.txtKetqua.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ket qua";
            // 
            // FormTinhTong
            // 
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 340);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.label1);
            this.Name = "FormTinhTong";
            this.Text = "FormTinhTong";
            this.Load += new System.EventHandler(this.FormTinhTong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Label label3;
    }
}