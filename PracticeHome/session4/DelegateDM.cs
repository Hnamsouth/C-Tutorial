using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.PracticeHome.session4
{
    public delegate void PrintString(String s);
    internal class DelegateDeMo
    {
        public DelegateDeMo() { }
        public void ShowMessage(String s)
        {
            Console.WriteLine("ShowMassage : "+s);
        }
        public static void Alert(String s)
        {
            Console.WriteLine("Alert: " + s);
        }
        
    }
}
