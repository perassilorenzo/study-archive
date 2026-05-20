using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0119_es21pag84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 21 pagina 84
            // spostare di una posizione il contenuto di un vettore di interi A di lunghezza n, rendendolo circolare

            int n = LeggiNumero("Inserisci la lunghezza del vettore", true);

            int[] A = new int[n];

            for (int i = 0; i < n; i++)
            {
                A[i] = LeggiNumero($"Inserisci l'elemento numero {i + 1}", true);
            }

            Spostamento(A);
        }

        private static void Spostamento(int[] a)
        {
            int ultimo = a[a.Length - 1];

            for (int i = a.Length - 1; i > 0; i--)
            {
                a[i] = a[i - 1];
            }

            a[0] = ultimo;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        private static int LeggiNumero(string v, bool isPositive)
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
                    Console.WriteLine("Inserire un valore valido");
                    Console.Clear();
                    Console.ReadKey();
                }
                if (isCorrect && isPositive && n < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero positivo");
                    Console.Clear();
                    Console.ReadKey();
                }

            } while (!isCorrect);
            
            return n;
        }

    }
}
