using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignment.ASM3
{
    class Ctm
    {
        public string MKH { get; set; }
        public string HoTen { get; set; }
        public string NgayRHH { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public virtual void ThanhTien() { }
    }
     class CtmVN:Ctm
    {
        public string DoiTuongKH { get; set; }
        public CtmVN() { }

        public override void ThanhTien()
        {
            if (SoLuong <= 50)
            {
                DonGia= SoLuong * 1000;
            }
            else if (SoLuong <= 100) 
            {
                DonGia =(1000*50)+ ( (SoLuong-50) * 1200);
            }else if (SoLuong <= 200)
            {
                DonGia = (1200 * 100) + ((SoLuong - 100) * 1500);
            }
            else
            {
                DonGia = (1500 * 200) + ((SoLuong - 200) * 2000);
            }
            
        }
    }
    class CtmNN : Ctm
    {
        public string Quoctich { get; set; }
        public CtmNN() { }
        public override void ThanhTien()
        {
            DonGia= SoLuong * 2000;
        }
    }
}
