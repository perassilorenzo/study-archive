using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_es34pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verificare se un numero intero positivo n fornito in ingresso è un numero abbondante

            int n = LeggiNumero("Inserisci un numero intero positivo da verificare");

            if (IsAbundant(n))
            {
                Console.WriteLine($"Il numero {n} è un numero abbondante");
            }
            else
            {
                Console.WriteLine($"Il numero {n} non è un numero abbondante");
            }
        }

        private static bool IsAbundant(int n)
        {
            return (!IsDefective(n));
        }

        private static bool IsDefective(int n)
        {
            int sum = 0, i = 1;

            do
            {
                if (n % i == 0)
                {
                    sum += i;
                }
                i++;

            } while (i <= n / 2);

            return (sum < n);
        }


        private static int LeggiNumero(string v, bool soloPositivi = true)
        {
            int n;
            bool isCorrect;

            do
            {
                Console.WriteLine(v);

                if (int.TryParse(Console.ReadLine(), out n))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && n <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero positivo");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!isCorrect);
        
            return n;
        }
    }
}
