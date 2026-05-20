using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207_es41pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 41 pagina 85
            // verificare se una matrice quandrata di interi A di ordine (r x r) è a spirale

            int n = LeggiNumero("Inserisci il lato della matrice quadrata");
            int[,] A = RiempiMatrice(n);

            if (Verifica(A, n)) Console.WriteLine("La matrice è a spirale");
            else Console.WriteLine("La matrice non è a spirale");

            
        }

        private static bool Verifica(int[,] a, int n)
        {
            int numero = 1;
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;

            while (top <= bottom && left <= right)
            {
                for (int j = left; j <= right; j++)
                {
                    if (a[top, j] != numero) return false;
                    numero++;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    if (a[i, right] != numero) return false;
                    numero++;
                }
                right--;

                if (top <= bottom)
                {
                    for (int j = right; j >= left; j--)
                    {
                        if (a[bottom, j] != numero) return false;
                        numero++;
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        if (a[i, left] != numero) return false;
                        numero++;
                    }
                    left++;
                }
            }

            return true;
        }

        private static int[,] RiempiMatrice(int n)
        {
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = LeggiNumero($"Inserisci il numero di coordinate {i}, {j}");
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
