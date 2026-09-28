using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0928_oop_modulo21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcolatore calcolatore = new Calcolatore();

            Console.WriteLine($"La somma di 2 e 3 è: {calcolatore.Somma(2, 3)}");
            Console.WriteLine($"La somma di 2,2 e 3,4 è: {calcolatore.Somma(2.2, 3.4)}");
            Console.WriteLine($"La somma di 2, 3 e 1 è: {calcolatore.Somma(2, 3, 1)}");

            Console.ReadKey();
        }
    }
}
