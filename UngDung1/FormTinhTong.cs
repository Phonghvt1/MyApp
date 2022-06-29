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
    public partial class FormTinhTong : Form
    {
        public FormTinhTong()
        {
            InitializeComponent();
        }

        private void FormTinhTong_Load(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
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
                txtKetqua.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
