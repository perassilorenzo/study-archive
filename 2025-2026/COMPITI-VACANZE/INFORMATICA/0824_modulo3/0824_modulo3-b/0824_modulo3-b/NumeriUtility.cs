using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0824_modulo3_b
{
    public class NumeriUtility
    {
        public static double Quadrato(double a)
        {
            return a * a;
        }

        public static bool Verifica(int a)
        {
            return a % 2 == 0;
        }

        public static double Max(double a, double b)
        {
            if (a > b) return a;
            return b;
        }
    }
}
