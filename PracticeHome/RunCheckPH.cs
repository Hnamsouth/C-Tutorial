using CSharp.PracticeHome.Session3;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.PracticeHome
{
    internal class RunCheckPH
    {
        static void Main1(string[] args)
        {
            // session 3:
            Oto o = new() { Brand = "Toyota", Type = "asd", Price = 100000 };
            Console.WriteLine(o[0]);
            // o[2] = "led"  -> error
            // khi dùng list. khi add 1 phần tử thì nó mới thêm 1 ô nhớ;

            // try catch

            try {
                if (5 < 6)
                {
                    //throw new Exception("err");
                }
                //Console.WriteLine(o[5]);

            }
            catch (Exception e) { Console.WriteLine(e.Message); }

            DateTime d = DateTime.Now;
            Console.WriteLine(d);
            
        }
    }
}
