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
        private List<String> phone = new List<String>();

        public List<String> Phone { 
            get { return phone; }
            set { phone.Add(value.ToString()); }
        }
        public PhoneNumber() { }
        public PhoneNumber(String n,String p) {
            this.name = n;
            this.Phone.Add(p);
        }


    }
    abstract class Phone
    {
        public abstract void InsertPhone(String name, String phone);
        public abstract bool RemovePhone(String name);
        public abstract bool UpdatePhone(String name, String oldPhone, String newPhone);
        public abstract PhoneNumber SearchPhone(String name);
        public abstract void Sort();
    }
}
