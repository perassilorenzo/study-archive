using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0824_modulo3_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ci aspettiamo 25
            Console.WriteLine(NumeriUtility.Quadrato(5));
            
            // ci aspettiamo false
            Console.WriteLine(NumeriUtility.Verifica(5));

            // ci aspettiamo 25
            Console.WriteLine(NumeriUtility.Max(5, 25));
        }
    }
}
