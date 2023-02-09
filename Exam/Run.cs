using CSharp.Exam.Exercise1;
using CSharp.Exam.Exercise2;
using CSharp.PracticeHome.Session5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exam
{
    internal class Run
    {
         static void Main1(string[] args) // Exercise 1:
        {
            Cylinder c1= new Cylinder(38.64,22.48);
            c1.Process();
            c1.Result();
        } 
        static void Main(string[] args) // Exercise 2:
        {
            Lion l1 = new Lion(100,"Lion");
            l1.Show();
            Tiger t1 = new Tiger(200, "Tiger");
            t1.Show();
        }
    }
}
