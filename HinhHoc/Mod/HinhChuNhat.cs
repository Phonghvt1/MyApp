using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc.Mod
{
    class HinhChuNhat
    {
        public double chieudai { get; set; }
        public double chieurong { get; set; }

        internal double DienTich()
        {
            return chieudai * chieurong;
        }

        internal double ChuVi()
        {
            return (chieurong + chieudai) * 2;
        }
    }
}
