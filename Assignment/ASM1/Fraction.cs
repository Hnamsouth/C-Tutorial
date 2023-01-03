using System;
using System.Runtime.CompilerServices;

namespace CSharp.Assignment.ASM1
{
     class Fraction
    {
        private int tuso, mauso;
     
        // getter - setter
        public int TuSo
        {
            get { return this.tuso; }
            set { this.tuso = value; }
        }
        public int MauSo
        {
            get { return this.mauso; }
            set { this.mauso = value; }
        }

        // constructor
        public Fraction() { }
        public Fraction(int ts, int ms) {
            TuSo = ts;
            MauSo = ms;
        }
        //  1. In PS 
        public void InPhanSo()
        {
            Console.WriteLine(TuSo +" / "+MauSo );
        }
        // 2. Rut Gon PS
        public void RutGonPS()
        {
            int min = Math.Min(Math.Abs(TuSo), Math.Abs(MauSo));
            for(int i = min; i < 0; i++)
            {
                if(TuSo%i==0 && MauSo % i == 0)
                {
                    TuSo /= i;MauSo /= i;
                    break;
                }
            }
        }
        //  3. Nghich dao PS
        public void NghichDaoPS()
        {
            int s = TuSo;
            TuSo = MauSo;
            MauSo = s;
        }
        //  4. Add
        public Fraction AddPS(Fraction f)
        {
            if (MauSo == TuSo)
            {
                return new Fraction((TuSo+MauSo),MauSo);
            }
            return new Fraction((TuSo*f.MauSo + MauSo*f.TuSo),( MauSo*f.MauSo));
        }
        //  5. Sub
        public Fraction SubPS(Fraction f)
        {
            if (MauSo == TuSo)
            {
                return new Fraction((TuSo - MauSo), MauSo);
            }
            return new Fraction((TuSo * f.MauSo - MauSo * f.TuSo), (MauSo * f.MauSo));
        }
        //  6. Mul
        public Fraction MulPS(Fraction f)
        {
            return new Fraction((TuSo * f.TuSo), (MauSo * f.MauSo));
        }
        //  7. Div
        public Fraction DivPS(Fraction f)
        {
            return new Fraction((TuSo * f.MauSo), (MauSo * f.TuSo));
        }

    }
}
