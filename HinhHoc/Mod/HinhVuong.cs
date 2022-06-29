using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc.Mod
{
    class HinhVuong
    {
        public double canh { get; set; }

        public double ChuVi() {
            return canh * 4;
        }
        public double DienTich() {
            return canh * canh;
        }
    }
}
