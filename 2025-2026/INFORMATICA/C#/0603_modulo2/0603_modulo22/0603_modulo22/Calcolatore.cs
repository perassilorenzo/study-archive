using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo22
{
    public class Calcolatore
    {
        // Metodo per sommare due numeri interi
        public int Somma(int a, int b)
        {
            return a + b;
        }

        // Overload: Somma due numeri double
        public double Somma(double a, double b)
        {
            return a + b;
        }

        // Overload: Somma tre numeri interi
        public int Somma(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
