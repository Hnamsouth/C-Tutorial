using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignment.ASM2
{
    internal class PhoneBook : Phone
    {
        List<PhoneNumber> PhoneList= new List<PhoneNumber>();
        public override void InsertPhone(string n, string p)
        {
            PhoneList.ForEach( pl =>
            {
                if (pl.name.Equals(n))
                {
                    if (pl.phone.Contains(p)){
                        return ;
                    }else{
                        pl.phone.Add(p);
                    }
                    return;
                }
            });
            PhoneList.Add(new PhoneNumber(n, p));
        }

        public override void RemovePhone(string n)
        {
            PhoneList.ForEach(pl => {
                if (pl.name.Equals(n)){
                    PhoneList.Remove(pl);
                    return;
                } 
            });
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

        public override void UpdatePhone(string n, string oldPhone, string newPhone)
        {
            PhoneList.ForEach(pl =>
            {
                if (pl.name.Equals(n))
                {
                    if (pl.phone.Contains(oldPhone))
                    {
                        pl.phone.Remove(oldPhone);
                        pl.phone.Add(newPhone); 
                        return;
                    }else{
                        Console.WriteLine("ko tim thay so can sua");
                    }
                    return;
                }else
                {
                    Console.WriteLine("ten khong chinh xac");
                }
            });
        }
    }
}
