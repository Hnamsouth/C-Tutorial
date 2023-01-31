using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignment.ASM6
{
    class MenuFunction
    {
        public List<Student> students;

        public MenuFunction()
        {
            students = new List<Student>();
        }
//  1. Thêm sinh viên.
        public void AddSTD(int id, string ten, int tuoi, string gioitinh, double dToan, double dVatLy, double dHoa)
        {
     
            students.Add(new Student( id,ten,tuoi,gioitinh,dToan,dVatLy,dHoa));
        }
//2. Cập nhật thông tin sinh viên bởi ID.
        public void UpdateSTD(int id, string ten, int tuoi, string gioitinh, double dToan, double dVatLy, double dHoa)
        {
                Student s = students.Find(st => st.ID.Equals(id));
                students.Remove(s);
                students.Add(new Student(id, ten, tuoi, gioitinh, dToan, dVatLy, dHoa));
            
        }
        //3. Xóa sinh viên bởi ID.
        public void DeleteSTD(int id)
        {
            Student s = students.Find(st => st.ID.Equals(id));
            students.Remove(s);
        }
        //4. Tìm kiếm sinh viên theo tên.
        public Student SearchSTD(string name)
        {
            return students.Find(st => st.Ten.Equals(name));
        }
        //5. Sắp xếp sinh viên theo điểm trung bình (GPA).
        public void SortByabs()
        {
            students.Sort((o1, o2) =>
            {
                return o1.DiemTB.CompareTo(o2.DiemTB);
            });
        }
        //6. Sắp xếp sinh viên theo tên.
        public void SortByName()
        {
            students.Sort((o1, o2) =>
            {
                return o1.Ten.CompareTo(o2.Ten);
            });
        }
        //6. Sắp xếp sinh viên theo ID.
        public void SortByID()
        {
            students.Sort((o1, o2) =>
            {
                return o1.ID.CompareTo(o2.ID);
            });
        }
    }
}
