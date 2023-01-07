using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignment.ASM2
{
    internal class RunTest
    {
        static void MainT(string[] args)
        {
            PhoneBook pb= new PhoneBook();
            pb.InsertPhone("hoang a", "1");
            pb.InsertPhone("hoang a", "2");
            pb.InsertPhone("hoang b", "1");

            Console.WriteLine(pb.SearchPhone("hoang a").Phone.First());

            Console.WriteLine("remove phone : " + pb.RemovePhone("hoang b"));
        }
    }
}
