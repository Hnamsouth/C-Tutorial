using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignment.ASM2
{
    internal class PhoneBook : Phone
    {
        private List<PhoneNumber> phonelist = new List<PhoneNumber>();
        public List<PhoneNumber> PhoneList { 
            get { return phonelist; }
            set { phonelist = value; }
        }
        public PhoneBook() { }
        public override void InsertPhone(string n, string p)
        {
            PhoneList.ForEach( pl =>
            {
                if (pl.name.Equals(n))
                {
                    if (pl.Phone.Contains(p)){
                        return ;
                    }else{
                        pl.Phone.Add(p);
                    }
                    return;
                }
            });
            PhoneList.Add(new PhoneNumber(n, p));
        }

        public override bool RemovePhone(string n)
        {
            foreach (PhoneNumber pl in PhoneList)
            {
                if (pl.name.Equals(n))
                {
                    PhoneList.Remove(pl);
                    return true;
                }
            }
            return false;
        }

        public override PhoneNumber SearchPhone(string n)
        {
            
            foreach(PhoneNumber pl in PhoneList){
                if (pl.name.Equals(n)){
                    return pl;
                }
            }
            return null;
        }

        public override void Sort()
        {
            // c1:
            PhoneList.Sort((n1, n2) =>
            {
                return n1.name.CompareTo(n2.name);
            });
            // c2: 
            for(int i = 0; i < PhoneList.Count-1; i++)
            {
                for (int j = i+1; j < PhoneList.Count; j++)
                {
                    if (PhoneList[i].name.CompareTo(PhoneList[j].name) > 0)
                    {
                        PhoneNumber a= PhoneList[i];
                        PhoneList[i] = PhoneList[j];
                        PhoneList[j] = a;
                    }
                }
            }

        }

        public override bool UpdatePhone(string n, string oldPhone, string newPhone)
        {
            foreach(PhoneNumber pl in PhoneList)
            {
                if (pl.name.Equals(n))
                {
                    if (pl.Phone.Contains(oldPhone)){
                        pl.Phone.Remove(oldPhone);
                        pl.Phone.Add(newPhone);
                        return true;
                    }else
                    {
                        Console.WriteLine("ko tim thay so can sua");
                    }
                }else{
                    Console.WriteLine("ten khong chinh xac");
                }
            }
            return false;
        }
    }
}
