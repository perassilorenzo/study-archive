using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0124_es7pag115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 7 pagina 115
            // contare il numero di volte in cui un valore X ricevuto in ingresso compare tra gli elementi di un vettore A di lunghezza n

            int n = LeggiNumero("Inserisci la lunghezza del vettore");
            int[] A = RiempiVettore(n);
            int x = LeggiNumero("Inserisci l'elemento da ricercare");

            Console.WriteLine($"Il numero {x} compare {Count(A, x)} volte all'interno del vettore");
            
        }

        private static int Count(int[] a, int x)
        {
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x) count++;
            }

            return count;
        }

        private static int[] RiempiVettore(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = LeggiNumero($"Inserisci l'elemento numero {i} del vettore");
            }

            return array;
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
                    Console.Clear();
                    Console.ReadKey();
                }
                if (isCorrect && soloPositivi && n < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero positivo");
                    Console.Clear();
                    Console.ReadKey();
                }

            } while (!isCorrect);

            return n;
        }
    }
}
