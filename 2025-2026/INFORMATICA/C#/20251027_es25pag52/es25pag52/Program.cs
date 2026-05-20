using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es25pag52
{
    internal class Program
    {
        private static int LeggiNumero(string messaggio)
        {
            int numero;
            bool isCorrect = true;

            do
            {
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Inserisci un numero valido");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!isCorrect);
            return numero;

        }
        static void Main(string[] args)
        {
            // coalcolare la media aritmetica di n numeri ricevuri in ingresso, con n > 0

            int n = LeggiNumero("Inserire il numero di inserimenti");
            int somma = 0; 

            for(int i = 0; i <= n; i++)
            {
                int numero = Console.Read();
                somma += numero;
            }

            Console.WriteLine(somma / n);
            Console.ReadKey();
        }

    }
}
