using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_es33pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verificare se un numero intero positivo n fornito in ingresso è un numero deficiente

            int n = LeggiNumero("Inserire il numero intero e positivo da verificare");

            if (IsDefective(n))
            {
                Console.WriteLine($"Il numero {n} è difettivo");
            }
            else
            {
                Console.WriteLine($"Il numero {n} non è difettivo");
            }
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
                    Console.WriteLine("Devi inserire un valore valido");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && n <= 0)
                {
                    isCorrect= false;
                    Console.WriteLine("Il numero deve essere positivo");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!isCorrect);

            return n;
        }
    }
}
