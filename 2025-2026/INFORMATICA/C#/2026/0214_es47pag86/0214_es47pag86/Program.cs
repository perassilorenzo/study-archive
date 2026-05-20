using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0214_es47pag86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 47 pagina 86
            // verificare se gli elementi delle diagonali principali di due matrici quadrate di interi A e B entrambe di ordine (r x r) sono uguali

            int r = LeggiNumero("Inserisci il lato delle matrici");
            int[,] A = CreateMatrix(r);
            int[,] B = CreateMatrix(r);

            Console.WriteLine(EqualsDiagonals(A, B));

        }

        private static string EqualsDiagonals(int[,] a, int[,] b)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j && a[i, j] != b[i, j]) return "Le diagonali delle due matrici sono diverse";
                }
            }

            return "Le diagonali delle due matrice sono uguali";
        }

        private static int[,] CreateMatrix(int r)
        {
            int[,] matrix = new int[r, r];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = LeggiNumero($"Inserisci il numero di coordinate {i}, {j} della matrice");
                }
            }

            return matrix;
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
                    Console.WriteLine("Devi inserire un numero");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && n < 0)
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
