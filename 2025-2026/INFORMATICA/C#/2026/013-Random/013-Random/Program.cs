using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Random
{
    internal class Program
    {
        static Random rnd = new Random();  //rnd è un oggetto perché dopo c'è la new, è fuori dal main ed è una variabile globale che viene vista in tutto il code

        static int NumeroCasuale(int min, int max)
        {
            int val = rnd.Next(min, max);   //su return deve ritornare la variabile
            return val;
        }


        static void Main(string[] args)
        {
            int faccia1, faccia2;  //locale

            faccia1 = NumeroCasuale(1, 7);
            faccia2 = NumeroCasuale(1, 7);

            if (faccia1 == faccia2)
            {
                Console.WriteLine($"Hai fatto coppia: i risultati sono {faccia1} e {faccia2}");
            }
            else
            {
                Console.WriteLine($"Non hai fatto coppia: i risultati sono {faccia1} e {faccia2}");
            }
            Console.ReadKey();
        }
    }
}
