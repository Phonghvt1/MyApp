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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //admin
            //123456
            if(txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "123456") 
            {
               DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tai khoan hoac mat khau khong dung");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
