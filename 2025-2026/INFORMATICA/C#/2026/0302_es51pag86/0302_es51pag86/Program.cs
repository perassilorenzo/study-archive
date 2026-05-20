using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302_es51pag86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 51 pagina 86
            // calcolare le somme degli elementi delle colenne di una matrice id interi A di ordine (r x c), scrivendole in un vettrore riga di interi B di lunghezza c

            int r = ReadInteger("Inserisci il numero di righe della matrice");
            int c = ReadInteger("Inserisci il numero di colonne della matrice");

            int[,] A = GenerateMatrix(r, c);
            int[] B = GenerateArray(A, c);
        }

        private static int[] GenerateArray(int[,] a, int c)
        {
            int[] array = new int[c];

            for (int i = 0; i < a.GetLength(1); i++)
            {
                int sum = 0;

                for (int j = 0; j < a.GetLength(0); j++)
                {
                    sum += a[j, i];
                }

                array[i] = sum;
            }

            return array;
        }

        private static int[,] GenerateMatrix(int r, int c)
        {
            int[,] matrix = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = ReadInteger($"Inserire l'elemento di coordinate {i}, {j} della matrice");
                }
            }

            return matrix;
        }

        private static int ReadInteger(string v, bool integer = true)
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
                if (isCorrect && integer && n < 0)
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
