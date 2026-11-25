using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1123_interface02
{
    internal class Triangolo : IFormaGeometrica
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
        public Triangolo(double b, double h)
        {
            B = b;
            H = h;
        }
        public double CalcolaArea()
        {
            return b * h / 2;
        }

        public double CalcolaPerimetro()
        {
            double latoObliquo = Math.Sqrt(Math.Pow(b / 2.0, 2) + Math.Pow(h, 2));
            return b + 2 * latoObliquo;
        }

        public void Disegna()
        {
            throw new NotImplementedException();
        }
    }
}
