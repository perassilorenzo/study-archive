using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0123_es33pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calcolare la somma degli elementi alla colonna j (con 0 <= j <= c-1) di una matrice di interi A di ordine (r x c)
            // esercizio 33 pagina 85

            int r = LeggiNumero("Inserisci il numero di righe");
            int c = LeggiNumero("Inserisci il numero di colonne");

            int[,] A = RiempiMatrice(r, c);

            int j = LeggiNumero($"Inserisci la colonna da sommare (0 - {c - 1}):");

            Console.WriteLine($"La somma è {Sum(A, r, j)}");
        }

        private static int Sum(int[,] a, int r, int j)
        {
            int sum = 0;

            for (int i = 0; i < r; i++)
            {
                sum += a[i, j];
            }

            return sum;
        }

        private static int[,] RiempiMatrice(int r, int c)
        {
            int[,] matrix = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = LeggiNumero($"Inserisci l'elemento in posizione {i}, {j}");
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
