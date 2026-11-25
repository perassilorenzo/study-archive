using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1123_interface02
{
    internal class Cerchio : IFormaGeometrica
    {
        public double raggio;
        public double Raggio
        {
            get => raggio;
            set {
                if (value < 0)
                    raggio = 0;
                else
                    raggio = value;
            }
        }
        public Cerchio (double raggio)
        {
            Raggio = raggio;
        }

        public double CalcoloArea()
        {
            return Raggio * Raggio * Math.PI;
        }

        public double CalcoloPerimetro()
        {
            return Raggio * Math.PI * 2;
        }
        public void Disegna()
        {
            Console.WriteLine($"Cerchio di raggio {Raggio}");
        }
    }
}
