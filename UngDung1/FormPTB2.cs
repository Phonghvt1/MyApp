using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDung1.Model;

namespace UngDung1
{
    public partial class FormPTB2 : Form
    {
        public FormPTB2()
        {
            InitializeComponent();
        }

        private void txtSob_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void x_Click(object sender, EventArgs e)
        {

        }

        private void txtSoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {

        }

        private void btnTimx_Click(object sender, EventArgs e)
        {
            
            try
            {
                TTB2 ptb2 = InputForm();
                ptb2.Tinh();
                txtX.Text = string.Format("x1={0},x={1}", ptb2.x1, ptb2.x2);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private TTB2 InputForm()
        {
            
                double a, b, c;
                if(double.TryParse(txtSoa.Text, out a) == false) 
                {
                    txtSoa.Focus();
                    txtSoa.SelectAll();
                    throw new Exception("So a khong hop le");
                }
                if (double.TryParse(txtSob.Text, out b) == false)
                {
                    txtSob.Focus();
                    txtSob.SelectAll();
                    throw new Exception("So b khong hop le");
                }
                if (double.TryParse(txtSoc.Text, out c) == false)
                {
                    txtSoc.Focus();
                    txtSoc.SelectAll();
                    throw new Exception("So c khong hop le");
                }
                return new TTB2()
                {
                    soa = a,
                    sob = b,
                    soc = c
                };
        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPTB2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
