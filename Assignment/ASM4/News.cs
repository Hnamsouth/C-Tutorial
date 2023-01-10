using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignment.ASM4
{
    interface INews
    {
        void Display();
    }
    //
    internal class News : INews
    {
        public int ID{get;set;}
        public String Title { get;set;}
        public String PublishDate { get;set;}
        public String Author { get;set;}
        public String Content { get;set;}
        private float averagerate;
        public float AverageRate { get; }


        
   

        public News() { }

        public News(int v1, string v2, string v3, string v4, string v5)
        {
            this.ID = v1;
            this.Title = v2;
            this.PublishDate = v3;
            this.Author = v4;
            this.Content = v5;
        }

        public void Calculate(int[] RateList)
        {
            int a=0;
            foreach(int i in RateList)
            {
                a += i;
            }
            News n = new();
            averagerate = a / RateList.Length;
        }

        public void Display()
        {
            Console.WriteLine(
                "Title : "         + Title +    "\n"+
                "PublishDate : " + PublishDate+ "\n"+
                "Author : " + Author +          "\n"+
                "Content : " + Content +        "\n"+
                "AverageRate : " + AverageRate
                );
        }
    }
}
