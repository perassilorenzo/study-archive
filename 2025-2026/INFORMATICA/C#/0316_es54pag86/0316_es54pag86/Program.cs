using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0316_es54pag86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verificare se gli elementi al di sotto della diagonale principale di una marice quadrat A di ordine (r x r) sono tutti uguali tra di loro

            int r = ReadInt("Inserisci la dimensione della matrice");
            int[,] A = GenerateMatrix(r);

            Console.WriteLine(VerifyMatrix(A, r));
        }

        private static string VerifyMatrix(int[,] a, int r)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j && a[i + 1, j] != a[i + 2, j + 1]) return "Non sono uguali";
                }
            }

            return "Sono uguali";
        }

        private static int[,] GenerateMatrix(int r)
        {
            int[,] matrix = new int[r, r];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = ReadInt($"Inserisci l'elemento di coordinate {i}, {j} della matrice");
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
                    Console.WriteLine("Inserisci un numero");
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
