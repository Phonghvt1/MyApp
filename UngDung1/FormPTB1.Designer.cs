namespace UngDung1
{
    partial class FormPTB1
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
            this.a = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.btnTimx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(132, 55);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(29, 13);
            this.a.TabIndex = 0;
            this.a.Text = "So a";
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(185, 52);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(314, 20);
            this.txtSoa.TabIndex = 1;
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(185, 100);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(314, 20);
            this.txtSob.TabIndex = 3;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(132, 103);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(29, 13);
            this.b.TabIndex = 2;
            this.b.Text = "So b";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(185, 144);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(314, 20);
            this.txtX.TabIndex = 5;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(132, 147);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(23, 13);
            this.x.TabIndex = 4;
            this.x.Text = "X =";
            // 
            // btnTimx
            // 
            this.btnTimx.Location = new System.Drawing.Point(185, 201);
            this.btnTimx.Name = "btnTimx";
            this.btnTimx.Size = new System.Drawing.Size(75, 23);
            this.btnTimx.TabIndex = 6;
            this.btnTimx.Text = "Tim X";
            this.btnTimx.UseVisualStyleBackColor = true;
            this.btnTimx.Click += new System.EventHandler(this.btnTimx_Click);
            // 
            // FormPTB1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimx);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.x);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.b);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.a);
            this.Name = "FormPTB1";
            this.Text = "FormPTB1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Button btnTimx;
    }
}