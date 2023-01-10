using CSharp.Assignment.ASM1;
using CSharp.Assignment.ASM2;
using CSharp.Assignment.ASM3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignment
{
    internal class RunTest
    {
        public static void Main1(string[] args)
        {
            Fraction f = new();
            f.TuSo = 5;
            f.MauSo = 8;
            f.NghichDaoPS();
            f.InPhanSo();
        }
        static void Main2(string[] args)
        {
            PhoneBook pb = new PhoneBook();
            pb.InsertPhone("hoang a", "1");
            pb.InsertPhone("hoang a", "2");
            pb.InsertPhone("hoang b", "1");

            Console.WriteLine(pb.SearchPhone("hoang a").Phone.First());

            Console.WriteLine("remove phone : " + pb.RemovePhone("hoang b"));
        }
        static void Main3(string[] args)
        {
            CtmVN vn = new CtmVN() { MKH = "1", HoTen = "hoang nam", NgayRHH = "02/03/2022", SoLuong = 75 };
            vn.ThanhTien();
            Console.WriteLine(vn.DonGia);


        }
    }
}
