using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0119_es20pag84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //es20pag84
            // verificare se gli elementi di un vettore di interi A di lunghezza n sono tutti diversi

            int n = LeggiNumero("Inserisci la lunghezza del vettore");

            int[] A = new int[n];

            for (int i = 0; i < n; i++)
            {
                A[i] = LeggiNumero($"Inserisci l'elemento numero {i + 1}");
            }

            if (Diversi(A))
            {
                Console.WriteLine("Gli elementi dell'array sono distinti");
            }
            else
            {
                Console.WriteLine("Gli elementi dell'array non sono distinti");
            }
        }

        private static bool Diversi(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        return false;  
                    }
                }
            }
            return true;
        }

        private static int LeggiNumero(string v)
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
                    Console.WriteLine("Inserisci valore valido");
                    Console.Clear();
                    Console.ReadKey();
                }
            } while (!isCorrect);

            return n;
        }
        
    }
}
