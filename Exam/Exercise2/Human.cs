using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exam.Exercise2
{
    internal class Human
    {
        private string name;
        private double weight;

        public string Name { get => this.name;set=>this.name = value; }
        public double Weight { get => this.weight; set=>this.weight = value; }


        public virtual void Show()
        {
            Console.WriteLine(
                "Name: "+ Name+"\t"+
                "Weight: " + Weight
                );
        }
        public virtual void SetMe(double weight, string name)
        {
            Weight = weight;
            Name=name;
        }


    }
}
