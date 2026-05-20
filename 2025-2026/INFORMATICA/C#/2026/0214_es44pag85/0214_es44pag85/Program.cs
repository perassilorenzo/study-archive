using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0214_es44pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esercizio 44 pagina 84
            //verificare se gli elementi di una matrice di interi A di ordine (r x c) sono ordinati in ordine crescente

            int r = LeggiNumero("Inserisci il numero di righe della matrice");
            int c = LeggiNumero("Inserisci il numero di colonne della matrice");
            int[,] A = CreateMatrix(r, c);

            Console.WriteLine(Verifica(A, r, c));
        }

        private static int[,] CreateMatrix(int r, int c)
        {
            int[,] matrix = new int[r, c];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = LeggiNumero($"Inserisci l'elemento di coordinate {i}, {j}");
                }
            }

            return matrix;
        }

        private static string Verifica(int[,] a, int r, int c)
        {
            bool crescente = true;

            int i = 0;
            while (crescente && i < r - 1)
            {

                int j = 0;
                while (crescente && j < c - 1)
                {
                    if (a[i, j] > a[i, j + 1]) return "Gli elementi non sono in ordine crescente";
                    j++;
                }

                if (a[i, j] > a[i + 1, 0]) return "Gli elementi non sono in ordine crescente";
                i++;
            }

            return "Gli elementi sono in ordine crescente";
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
                    Console.Clear();
                    Console.ReadKey();
                }
                if (isCorrect && soloPositivi && n <= 0)
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
