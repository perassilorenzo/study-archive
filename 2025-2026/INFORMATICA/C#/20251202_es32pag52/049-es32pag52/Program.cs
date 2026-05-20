using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _049_es32pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verificare se un numeor intero positivo n inserito in ingresso è un numero primo

            int n = LeggiNumero("Inserire il numero da verificare");

            if (Primo(n))
            {
                Console.WriteLine($"{n} è un numero primo");
            }
            else
            {
                Console.WriteLine($"{n} non è un numero primo");
            }
        }

        private static bool Primo(int n)
        {
            if (n < 2) { return false; }
            int count = 0; 
            for (int i = 1;  i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            return (count == 2);
        }

        private static int LeggiNumero(string v, bool soloPositivi = true)
        {
            int n;
            bool isCorrect;

            do
            {
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
                if (isCorrect && soloPositivi && n < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero maggiore di zero");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return n;
        }
    }
}
