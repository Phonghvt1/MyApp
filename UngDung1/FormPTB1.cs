using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDung1
{
    public partial class FormPTB1 : Form
    {
        public FormPTB1()
        {
            InitializeComponent();
        }

        private void btnTimx_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (double.TryParse(txtSoa.Text, out a) == false)
                {
                    txtSoa.Focus();
                    txtSoa.SelectAll();
                    throw new Exception(" So a khong dung dinh dang");
                }
                if (double.TryParse(txtSob.Text, out b) == false)
                {
                    txtSob.Focus();
                    txtSob.SelectAll();
                    throw new Exception(" So b khong dung dinh dang");
                }
                if (a == 0)
                {
                    if (b == 0)
                    {
                        throw new Exception("Vo so nghiem");
                    }
                    else
                    {
                        throw new Exception("Vo nghiem");
                    }
                }
                txtX.Text = (-b / a).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
