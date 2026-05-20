using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_es35pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verificare se due interi positivi n1 e n2 in ingresso sono numeri amichevoli

            int n1 = LeggiNumero("Inserire il primo numero da verificare");
            int n2 = LeggiNumero("Inserire il secondo numero da verificare");

            if (AreAmicable(n1) == n2 && n1 == AreAmicable(n2))
            {
                Console.WriteLine($"I numeri {n1} e {n2} sono amichevoli");
            }
            else
            {
                Console.WriteLine($"I numeri {n1} e {n2} non sono amichevoli");
            }
        }

        private static int AreAmicable(int n)
        {
            int sum = 0, i = 1;

            do
            {
                if (n % i == 0)
                {
                    sum += i;
                }
                i++;

            } while (i <= n/2);

            return sum;
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
                    Console.WriteLine("Il numero deve essere valido");
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
