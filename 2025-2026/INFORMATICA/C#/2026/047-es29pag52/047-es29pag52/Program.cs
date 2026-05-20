using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _047_es29pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // visualizzare i fattori di un numero intero postivo n fornito in ingresso

            int n = LeggiNumero("Inserire il numero da verificare");
            int[] solution = Factiorial(n);
            WriteArray(solution);
        }

        private static void WriteArray(int[] solution)
        {
            for (int i = 0; i < solution.Length; i++)
            {
                Console.WriteLine(solution[i] + " ");
            }
        }

        private static int[] Factiorial(int n)
        {
            int[] result = new int[n];
            int j = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n %  i == 0) result[j] = i;
                j++;
            }

            Array.Resize(ref result, j);

            return result;
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
                    Console.WriteLine("Inserire numeri validi");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && n < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire numeri maggiori di zero");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return n;
        }
    }
}
