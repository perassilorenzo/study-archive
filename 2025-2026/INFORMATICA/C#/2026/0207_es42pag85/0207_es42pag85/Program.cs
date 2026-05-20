using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207_es42pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 42 pagina 85
            // caricare una matrice quandrata di interi A di ordine (r x r) a spirale partendo con il valore 1 in posizione 0, 0

            int n = LeggiNumero("Inserisci il lato della matrice");
            int[,] A = RiempiSpirale(n);
        }

        private static int[,] RiempiSpirale(int n)
        {
            int[,] matrix = new int[n, n];
            int numero = 1;
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;

            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    matrix[top, i] = numero;
                    numero++;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    matrix[i, right] = numero;
                    numero++;
                }
                right--;

                if (top <= bottom)
                {
                    for (int i = right; j >= left; j--)
                    {
                        matrix[bottom, i] = numero;
                        numero++;
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        matrix[i, left] = numero;
                        numero++;
                    }
                    left--;
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
