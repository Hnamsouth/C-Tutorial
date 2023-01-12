using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignment.AGM5.house.cm
{
    internal interface IHouse
    {
         public void input();

         public void display();
    }
    public class House : IHouse
    {
        private String sonha;
        private String diachi;
        private String loainha;

        // getter - setter
        public String SoNha { get => sonha;set => sonha = value; }
        public String DiaChi { get => diachi; set => diachi = value; }
        public String LoaiNha { get => loainha; set => loainha = value; }

        // constructor
        public House() { }
        public House(string soNha, string diaChi, string loaiNha)
        {
            this.soNha = soNha;
            this.diaChi = diaChi;
            this.loaiNha = loaiNha;
        }

        // overide interface
        public virtual void display() { }
        public virtual void input() { }
   
    }
}
