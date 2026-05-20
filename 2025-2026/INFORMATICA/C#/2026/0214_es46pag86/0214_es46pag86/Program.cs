using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0214_es46pag86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 46 pagina 86
            // caricare un matrice di interi A di ordine (r x c) di valori ordinati in ordine crescente

            int r = LeggiNumero("Inserire il numero di righe della matrice");
            int c = LeggiNumero("Inserire il numero delle colonne della matrice");

            PrintMatrix(CreateMatrix(r, c));


        }

        private static void PrintMatrix(int[,] ints)
        {
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] CreateMatrix(int r, int c)
        {
            int[,] matrix = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        matrix[i, j] = LeggiNumero($"Inserisci il numero di coordinate {i}, {j} della matrice");
                    }
                    else if (j == 0)
                    {
                        do
                        {
                            matrix[i, j] = LeggiNumero($"Inserisci il numero di coordinate {i}, {j} della matrice");
                        }
                        while (matrix[i, j] < matrix[i - 1, c - 1]);
                    }
                    else
                    {
                        do
                        {
                            matrix[i, j] = LeggiNumero($"Inserisci il numero di coordinate {i}, {j} della matrice");
                        }
                        while (matrix[i, j] < matrix[i, j - 1]);
                    }
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
