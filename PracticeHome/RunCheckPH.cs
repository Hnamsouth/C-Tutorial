using CSharp.PracticeHome.Session3;
using CSharp.PracticeHome.session4;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.PracticeHome
{
    //public delegate void PrintString(String s);
    internal class RunCheckPH
    {

        static void MainTest(string[] args) //ss4
        {
            DelegateDeMo.Alert("asd");
            DelegateDeMo d= new DelegateDeMo();
            d.ShowMessage("asd");

            PrintString ps = new PrintString(ShowDanger);
            
            // multi delegate
            ps += DelegateDeMo.Alert;
            ps += new DelegateDeMo().ShowMessage;

            ps("so danger");

            // ps -= DelegateDeMo.Alert; // co the loai bo multi delegate

            ps += (s) =>{}; //  cong ham an danh

            ps += delegate (string s) {
                Console.WriteLine("asdf " + s);
            };

            PrintString ps3 = delegate (string s) { 
            
            };
            
            DemoEvent de= new DemoEvent(ps3);
            de.ClickAction();


        }
        public static void ShowDanger(String s)
        {
            Console.WriteLine("Danger: " + s);
        }

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
