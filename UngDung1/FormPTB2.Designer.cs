namespace UngDung1
{
    partial class FormPTB2
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
            this.btnTimx = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.txtSoc = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTimx
            // 
            this.btnTimx.Location = new System.Drawing.Point(196, 261);
            this.btnTimx.Name = "btnTimx";
            this.btnTimx.Size = new System.Drawing.Size(75, 23);
            this.btnTimx.TabIndex = 13;
            this.btnTimx.Text = "Tim X";
            this.btnTimx.UseVisualStyleBackColor = true;
            this.btnTimx.Click += new System.EventHandler(this.btnTimx_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(196, 204);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(314, 20);
            this.txtX.TabIndex = 12;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(143, 207);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(23, 13);
            this.x.TabIndex = 11;
            this.x.Text = "X =";
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // txtSoc
            // 
            this.txtSoc.Location = new System.Drawing.Point(196, 160);
            this.txtSoc.Name = "txtSoc";
            this.txtSoc.Size = new System.Drawing.Size(314, 20);
            this.txtSoc.TabIndex = 10;
            this.txtSoc.TextChanged += new System.EventHandler(this.txtSob_TextChanged);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(143, 163);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(29, 13);
            this.b.TabIndex = 9;
            this.b.Text = "So c";
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(196, 88);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(314, 20);
            this.txtSoa.TabIndex = 8;
            this.txtSoa.TextChanged += new System.EventHandler(this.txtSoa_TextChanged);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(143, 91);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(29, 13);
            this.a.TabIndex = 7;
            this.a.Text = "So a";
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(196, 125);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(314, 20);
            this.txtSob.TabIndex = 15;
            this.txtSob.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "So b";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "GIAI PHUONG TRINH BAC 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormPTB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimx);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.x);
            this.Controls.Add(this.txtSoc);
            this.Controls.Add(this.b);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.a);
            this.Name = "FormPTB2";
            this.Text = "FormPTB2";
            this.Load += new System.EventHandler(this.FormPTB2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimx;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.TextBox txtSoc;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}