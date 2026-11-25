using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1123_interface02
{
    internal class Rettangolo : IFormaGeometrica
    {
        private double b, h;
        public double B
        {
            get => b;
            set
            {
                if (value < 0)
                    b = 0;
                else
                    b = value;
            }
        public double H
        {
            get => h;
            set
            {
                if (value < 0)
                    h = 0;
                else 
                    h = value;
            }
        }

        public Rettangolo(double b, double h)
        {
            B = b;
            H = h;
        }

        public double CalcolaArea()
        {
            return b * h;
        }

        public double CalcolaPerimetro()
        {
            return (b + h) * 2;
        }

        public void Disegna()
        {
            Console.WriteLine($"Rettangolo di base {b} e altezza {h}");
        }
    }
}
