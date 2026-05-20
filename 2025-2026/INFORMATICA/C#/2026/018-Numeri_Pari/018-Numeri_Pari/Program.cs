using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Numeri_Pari
{
    internal class Program
    {
        static int nNumeriPari = 0;
        static int cont = 2;
        const int numeriPari = 100;
        static void Main(string[] args)
        {
            do
            {
                if (cont % 2 == 0);
                {
                    nNumeriPari++;
                    Console.WriteLine($"Numero pari: {cont}");
                }
                cont++;
            } while (nNumeriPari < numeriPari);

            Console.ReadKey();


        }
    }
}
