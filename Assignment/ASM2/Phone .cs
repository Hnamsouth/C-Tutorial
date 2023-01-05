using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignment.ASM2
{
    class PhoneNumber
    {
        public String name { get; set; }
        public List<String> phone { get; set; }
        public PhoneNumber() { }
        public PhoneNumber(String n,String p) {
            
            this.name = n;
            this.phone.Add(p);
        }


    }
    abstract class Phone
    {
        public abstract void InsertPhone(String name, String phone);
        public abstract void RemovePhone(String name);
        public abstract void UpdatePhone(String name, String oldPhone, String newPhone);
        public abstract PhoneNumber SearchPhone(String name);
        public abstract void Sort();
    }
}
