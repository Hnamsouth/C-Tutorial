using CSharp.PracticeHome.Session3;
using CSharp.PracticeHome.session4;
using CSharp.PracticeHome.Session5;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.PracticeHome
{
    //public delegate void PrintString(String s);
    internal class RunCheckPH
    {
        // call api

        static async Task<RootWeather> CallAPIDemo2()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            HttpClient http = new HttpClient();
            var rs = await http.GetAsync(url);
            if(rs.StatusCode == HttpStatusCode.OK)
            {
                // rs.Content : return content of http response message
                string content = await rs.Content.ReadAsStringAsync();
                // convert to object
                RootWeather rwt = JsonConvert.DeserializeObject<RootWeather>(content);
                return rwt;
            }
            return null;
        }

        static async void GDT()
        {
            CallApi c = new CallApi();
            RootWeather rwt = await c.GetData();
            Console.WriteLine(rwt.main.temp);
        }


        public static void Main(string[] args)
        {
            GDT();

            //CallAPIDemo2();

            /*
            Thread t1 = new Thread(RunThread);
            t1.Start();
            //t1.IsBackground = true;

            Thread t2 = new Thread(delegate (){

                Console.WriteLine("thread Delegate demo");
                //
                Thread.Sleep(1000);
            });
            t2.Start();

            Thread t3 = new Thread(RunThread);
            t3.Start("nfks"); // any data
            Console.WriteLine("Main end");
            */
        }



        static void RunThread(object o)
        {
            for(int i=0; i<5; i++) {
                Console.WriteLine(o + " - " + i);
            }
        }
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
