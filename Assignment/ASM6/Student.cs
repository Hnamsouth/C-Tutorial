using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignment.ASM6
{
    class Student
    {
        /*
         *  id, tên, giới tính, tuổi, điểm toán, điểm lý, điểm hóa, điểm trung bình và học lực.
         */
        public int ID { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; } 
        public double DiemToan { get; set; }
        public double DiemVatLy { get; set; }
        public double DiemHoa { get; set; }
        public double DiemTB { get; set; }
        public string HocLuc { get; set; }

        public Student() { }

        public Student(int id,string ten, int tuoi,string gioitinh, double dToan, double dVatLy, double dHoa) {
            this.ID=id;
            this.Ten=ten;
            this.Tuoi=tuoi;
            this.GioiTinh=gioitinh;
            this.DiemToan=dToan;
            this.DiemVatLy=dVatLy;
            this.DiemHoa=dHoa;
            this.DiemTB = (DiemToan + DiemVatLy + DiemHoa) / 3;
            TinhHocLuc(this.DiemTB);

        }
        public void TinhHocLuc(double dtb)
        {
            if (dtb >= 8) { this.HocLuc = "Gioi"; }else
            if(dtb >= 6.5) { this.HocLuc = "Kha"; }else
            if (dtb >= 5) { this.HocLuc = "Trung Binh"; }
            else { this.HocLuc = "Yeu"; }
        }

    }
}
