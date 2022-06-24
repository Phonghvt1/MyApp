using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungMang
{
    class Program
    {
        static void Main(string[] args)
        {
            KhaiBaoMang();
            //XuatMangRaManHinh();
            //XuatSoChanTrongMang();
            //TimGiaTriLonNhatTrongMang;
            NhapMangSoNguyen();

            Console.ReadKey();
        }

        private static void NhapMangSoNguyen()
        {
            int SoPhanTu = NhapSoNguyenDuong("Nhap so phan tu: ");
            int[] a = new int[SoPhanTu];
            for (int i = 0; i < SoPhanTu; i++)
            {
                a[i] = NhapSoNguyenDuong(string.Format("Nhap Phan Tu Thu {0}", i + 1));
            }
        }

        private static int NhapSoNguyenDuong(string thongbao)
        {
            int a;
            bool kt;
            Console.WriteLine(thongbao);
            do
            {
                kt = int.TryParse(Console.ReadLine(), out a);
                if (kt == true)
                {
                    if (a <= 0)
                    {
                        kt = false;
                    }
                }
                if (kt == false)
                {
                    Console.WriteLine("Nhap lai: ");
                }
            } while (kt == false);

            return a;
        }

        private static void TimGiaTriLonNhatTrongMang()
        {
            int[] a = { 23, 56, 45, 78, 98, 45, 32, 95 };
            int b = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]>b)
                {
                    b = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("So lon nhat la: {0}", b);
        }

        private static void XuatSoChanTrongMang()
        {
            int[] a = { 23, 56, 45, 78, 98, 45, 32, 95 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine("{0} la so chan",a[i]);
                }
                else
                {
                    Console.WriteLine("{0} la so le", a[i]);
                }
            }
        }

        private static void XuatMangRaManHinh()
        {
            int[] a = { 23, 56, 45, 78, 98, 45, 32, 95 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static void KhaiBaoMang()
        {
            int[] a = { 23, 12, 1, 2, 5, 10, 223, 32};
            int[] b = new int[4];

        }
    }
}
