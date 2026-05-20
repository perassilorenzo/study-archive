using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _0124_es8pag115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 8 pagina 115
            // calcolare la somma degli elementi pari a quella degli elementi dispari presenti in un vettore di interi A di lunghezza n

            int n = LeggiNumero("Inserisci la lunghezza del vettore");
            int[] A = RiempiVettore(n);

            Console.WriteLine($"La somma degli elementi pari all'interno del vettore è {Sum(A, true)}, mentre di quelli dispari è {Sum(A, false)}");


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

        private static int Sum(int[] a, bool verifica)
        {
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (verifica && a[i] % 2 == 0) sum++;
                else if (!verifica && a[i] % 2 != 0) sum++;
            }

            return sum;
            
        }
    }
}
