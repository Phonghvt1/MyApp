using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungHamTT
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            // xuat ra man hinh
            Console.WriteLine("======Menu======");
            Console.WriteLine("1. Su Dung Vong Lap");
            Console.WriteLine("2. Tim So Lon Nhat");
            Console.WriteLine("3. Tinh tong cac so 1 -> 1/n");
            Console.WriteLine("4. Tinh N!");
            Console.WriteLine("5. Tinh Tong tu 1 -> N");
            // cho nguoi dung chon
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    SuDungVongLap();
                    break;
                case "5":
                    TinhTongToiN();
                    break;
                case "4":
                    TinhNGiaiThua();
                    break;
                case "3":
                    TimTong();
                    break;
            }
            Console.ReadKey();

        }

        private static void TimTong()
        {
            try
            {
                //nhap so nguyen N
                Console.WriteLine("Nhap so nguyen N: ");
                int n;
                bool kt =
                    int.TryParse(Console.ReadLine(), out n);
                if (kt == false)
                {
                    // nguoi dung nhap sai
                    throw new Exception("Chuoi khong dung dinh dang");
                }
                // nhap dung
                if (n <= 0)
                {
                    throw new Exception("N phai lon hon 0");
                }
                double tong = 0;
                for (int i = 1; i <= n; i++)
                {
                    tong = tong + 1.0/i;

                }
                Console.WriteLine("Tong = {0}", tong);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void TinhNGiaiThua()
        {
            try
            {
                //nhap so nguyen N
                Console.WriteLine("Nhap so nguyen N: ");
                int n;
                bool kt =
                    int.TryParse(Console.ReadLine(), out n);
                if (kt == false)
                {
                    // nguoi dung nhap sai
                    throw new Exception("Chuoi khong dung dinh dang");
                }
                // nhap dung
                if (n <= 0)
                {
                    throw new Exception("N phai lon hon 0");
                }
                int giaithua = 1;
                for (int i = 1; i <= n; i++)
                {
                    giaithua = giaithua * i;
                   
                }
                Console.WriteLine("N!= {0}", giaithua);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void TinhTongToiN()
        {
            try
            {
                //nhap so nguyen N
                Console.WriteLine("Nhap so nguyen N: ");
                int n = int.Parse(Console.ReadLine());
                int tong = 0;
                for (int i = 1; i <= n; i++)
                {
                    tong = tong + i;
                }
                Console.WriteLine("Tong Toi N La: {0}", tong);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void SuDungVongLap()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Xin chao");
                Console.WriteLine(i+1);
            }
        }
    }
}
