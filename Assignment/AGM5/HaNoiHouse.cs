using CSharp.Assignment.AGM5.house.cm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CSharp.Assignment.AGM5.house.hanoi
{
    internal class HaNoiHouse : House
    {
        // attribu
        private String tenQuan;
        public String TenQuan { get => tenQuan; set => tenQuan = value; }
        // contructor
        public HaNoiHouse() { } 
        public HaNoiHouse(string soNha, string diaChi, string loaiNha, String tenQuan) : base(soNha, diaChi, loaiNha)
        {
            this.tenQuan = tenQuan;
        }
        // overide 
        public override void display() { }
        public override void input() { }

    }
    internal class ManagerHouse
    {
        List<HaNoiHouse> listHNH;
        public ManagerHouse()
        {
            listHNH= new List<HaNoiHouse>();
        }
        //1. Nhập thông tin n ngôi nhà ở Hà Nội
        public void AddHouse(HaNoiHouse hnn)
        {
            listHNH.Add(hnn);
        }

        //2. Hiển thị thông tin của n ngôi nhà đó.
        public void ShowHouse()
        {
            listHNH.ForEach(h =>
            {
                Console.WriteLine( 
                    "So Nha: " + h.SoNha +"\n"+
                    "Dia Chi: " + h.DiaChi +"\n"+
                    "Loai Nha: " + h.LoaiNha +"\n"+
                    "Ten Quan: " + h.TenQuan 

                    );   
            });
        }

        //3. Sắp xếp theo trường địa chỉ và hiển thị thông tin sau khi sắp xếp.
        public void SortByAddress()
        {
            listHNH.Sort((o1, o2) =>
            {
                return o1.DiaChi.CompareTo(o2.DiaChi);
            });
        }

        //4. Tìm kiếm nhà theo địa chỉ nhập vào.
        public HaNoiHouse FHouse(string address)
        {
            /*
            HaNoiHouse sd = listHNH.Find(h => h.DiaChi.Equals(address));
            return sd;
            */
            return listHNH.Find(h => h.DiaChi.Equals(address));
        }
    }
}
