using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcolatore calcolatore = new Calcolatore();

            int somma1 = calcolatore.Somma(2, 2);
            Console.WriteLine(somma1);

            double somma2 = calcolatore.Somma(6, 7);
            Console.WriteLine(somma2);

            int somma3 = calcolatore.Somma(1, 2, 3);
            Console.WriteLine(somma3);
        }
    }
}
