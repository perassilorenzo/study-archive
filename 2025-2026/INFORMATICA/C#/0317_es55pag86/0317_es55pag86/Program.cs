using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _0317_es55pag86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verificare se gli elementi al di sopra della diagonale principale di una matrice A di ordine (r x r) sono tutti maggiori di 0

            int r = ReadInt("Inserisci la lunghezza della matrice");
            int[,] A = GenerateMatrix(r);

            Console.WriteLine(VerifyInt(A, r));
        }

        private static string VerifyInt(int[,] a, int r)
        {
            for (int i = 1; i < a.GetLength(0); i++)
                for (int j = 1; j < a.GetLength(1); j++)
                {
                    if (i == j && a[i + 1, j] <= 0) return "Non sono maggiori";
                }

            return "Sono maggiori";
        }

        private static int[,] GenerateMatrix(int r)
        {
            int[,] matrix = new int[r, r];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = ReadValue($"Inserisci l'elemento della matrice di coordinate {i}, {j}");
                }

            return matrix;
        }

        private static int ReadValue(string v)
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
                    Console.WriteLine("Devi inserire un numero");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return n;
        }

        private static int ReadInt(string v)
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
                    Console.WriteLine("Devi inserire un numero");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && n < 0)
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
