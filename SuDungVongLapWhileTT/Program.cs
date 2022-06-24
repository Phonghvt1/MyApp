using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungVongLapWhileTT
{
    class Program
    {
        static void Main(string[] args)
        {
            //UCLN();
            //XacDinhSoNguyenTo();
            //XacDinhNguyenTo();
            //int a = NhapSoNguyen();
            int b = NhapSoNguyenDuong();
            Console.ReadKey();
        }

        private static int NhapSoNguyenDuong()
        {
            int a;
            bool kt;
            Console.WriteLine("Nhap so nguyen duong: ");
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
            } while (kt==false);
            return a;
        }

        private static int NhapSoNguyen()
        {
            int a;
            Console.WriteLine("Nhap so nguyen a: ");
            while (int.TryParse(Console.ReadLine(),out a) == false)
            {
                Console.WriteLine("Nhap lai: ");
            }
            return a;
        }

        private static void XacDinhSoNguyenTo()
        {
            Console.WriteLine("Nhap so nguyen to N: ");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            while (i <= n)
            {
                if (n%i == 0)
                {
                    if (n == i)
                    {
                        Console.WriteLine("{0} la so nguyen to", n);
                    }
                    else
                    {
                        Console.WriteLine("{0} khong la so nguyen to", n);
                    }
                    break;
                }
                i++;
            }
        }

        private static void XacDinhNguyenTo()
        {
            Console.WriteLine("Nhap so nguyen N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (n == i)
                    {
                        Console.WriteLine(" {0} la so nguyen to", n);
                    }
                    else
                    {
                        Console.WriteLine(" {0} Khong phai la so nguyen to", n);
                    }
                    break;
                }
            }
        }

        private static void UCLN()
        {
            //
            Console.WriteLine("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            while (a*b > 0)
            {
                if (a < b)
                {
                    b = b % a;
                }
                else
                {
                    a = a % b;
                }
            }
            Console.WriteLine("UCLN La: {0}", a + b);
        }
    }
}
