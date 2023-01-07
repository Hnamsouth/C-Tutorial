using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignment.ASM3
{
    internal class RunCheck
    {
        static void Main(string[] args)
        {
            CtmVN vn = new CtmVN() {MKH="1",HoTen="hoang nam",NgayRHH="02/03/2022",SoLuong=75 };
            vn.ThanhTien();
            Console.WriteLine(vn.DonGia);
         
        }
    }
}
