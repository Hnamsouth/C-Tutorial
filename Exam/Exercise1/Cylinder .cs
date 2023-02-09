using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exam.Exercise1
{
    internal class Cylinder
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        private double BaseArea { get; set; }
        private double LateralArea { get; set; }
        private double TotalArea { get; set; }
        private double Volume { get; set; }
        public Cylinder(double r,double h) {
            Radius= r;
            Height= h;
        }

        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }
        public void Result()
        {
            Console.WriteLine(
                "Radius: "+ Radius+ ", Height: "+ Height+"\n"+
                "Base: "+ BaseArea + "\n"+
                "Lateral: " + LateralArea + "\n"+
                "Total: " + TotalArea + "\n"+
                "Volume: " + Volume
                );
        }
    }

}
