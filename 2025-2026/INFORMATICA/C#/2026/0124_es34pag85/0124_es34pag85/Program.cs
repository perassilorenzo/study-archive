using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0124_es34pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 34 pagina 85
            // contare il numero di volte in cui un valore X ricevuto in ingresso compare tra tra gli elementi di una matrice
            // di interi A di ordine (r, c)

            int r = LeggiNumero("Inserisci il valore delle righe della matrice");
            int c = LeggiNumero("Inserisci il valore delle colonne della matrice");

            int[,] A = new int[r, c];

            A = RiempiMatrice(r, c);

            int x = LeggiNumero("Inserisci il numero da ricercare");

            Console.WriteLine($"L'elemento {x} compare {Count(A, r, c, x)} volte");
        }

        private static int Count(int[,] a, int r, int c, int x)
        {
            int count = 0;

            for (int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    if (a[i, j] == x) count++;
                }
            }

            return count;
        }

        private static int[,] RiempiMatrice(int r, int c)
        {
            int[,] matrix = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = LeggiNumero($"Inserisci l'elemento della matrice di cordinate {i}, {j}");
                }
            }

            return matrix;
        }

        private static int LeggiNumero(string v, bool soloPositivi = true)
        {
            int n = 0;
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
