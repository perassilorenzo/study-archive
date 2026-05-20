
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0316_es53pag86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calcolare la somma degli elemtgni al di sotto della diagonale sedondaria di una matrice qauadreat di interi A di ordine (r x r)

            int r = ReadInt("Inserisci la dimensione della matrice");
            int[,] A = GenerateMatrix(r);

            Console.WriteLine($"La somma è {CountSum(A, r)}");
        }

        private static object CountSum(int[,] a, int r)
        {
            int sum = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i + j == r - 1) sum += a[i + 1, j];
                }
            }

            return sum;
        }

        private static int[,] GenerateMatrix(int r)
        {
            int[,] matrix = new int[r, r];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = ReadInt($"Inserisci l'elemento di coordinate {i}, {j}");
                }
            }

            return matrix;
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
                    Console.WriteLine("Inserisci un valore valido");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && n < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Inserisci un numero positivo");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return n;
        }
    }
}
