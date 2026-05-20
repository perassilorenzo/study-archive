using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _0127_es36pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 36 pagina 85
            // verificare se la somma degli elementi sulla diagonale principale è uguale a quella sulla diagonale secondaria
            // in una matrice quadrata di interi A di ordine (r x r)

            int n = LeggiNumero("Inserisci il lato della matrice");
            int[,] A = new int[n, n];

            RiempiArray(A, n);

            if (Verifica(A, n)) Console.WriteLine("Sono uguali");
            else Console.WriteLine("Sono diversi");
        }

        private static void RiempiArray(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = LeggiNumero($"Inserisci A[{i},{j}]");
                }
            }
        }

        private static bool Verifica(int[,] a, int n)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                sum1 += a[i, i];           
                sum2 += a[i, n - 1 - i];   
            }

            return sum1 == sum2;

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
