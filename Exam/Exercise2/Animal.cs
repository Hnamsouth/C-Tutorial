using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exam.Exercise2
{
    internal class Animal
    {
        private string name;
        private double weight;

        public string Name { get => this.name;set=>this.name = value; }
        public double Weight { get => this.weight; set=>this.weight = value; }

        public  void Show()
        {
            Console.WriteLine(
                "Name: "+ Name+"\t"+
                "Weight: " + Weight
                );
        }
        public  void SetMe(double weight, string name)
        {
            Weight = weight;
            Name=name;
        }


    }
}
