using HinhHoc.Mod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            HinhVuong hv = new HinhVuong()
            {
                canh = 4
            };
            HinhVuong hv1 = new HinhVuong();
            hv1.canh = 10;
            Console.WriteLine(hv.DienTich());
            Console.WriteLine(hv.ChuVi());
            Console.ReadKey();
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.chieudai = 5;
            hcn.chieurong = 4;
            double cv = hcn.ChuVi();
            double dt = hcn.DienTich();
            Console.WriteLine(" Chu Vi = {0}", cv);
            Console.WriteLine(" Dien Tich = {0}", dt);
            Console.ReadKey();
        }
    }
}
