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
    public partial class Form1 : Form
    {
        private static bool isLogin = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form fLogin = new FormDangNhap();
            var result = fLogin.ShowDialog();
            if (result != DialogResult.OK)
            {
                Close();
            }
            isLogin = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogin == false)
            {
                return;
            }
            //Thong bao co dong form khong?
            var result = MessageBox.Show("Ban co muon Thoat khong?", "Thong bao", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            Form ftinhtong = new FormTinhTong();
            ftinhtong.ShowDialog();
        }

        private void btnTinhPTB1_Click(object sender, EventArgs e)
        {
            Form ftinhptb1 = new FormPTB1();
            ftinhptb1.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form ftinhptb2 = new FormPTB2();
            ftinhptb2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fnhanvien = new FormNhanVien();
            fnhanvien.ShowDialog();
        }
    }
}
