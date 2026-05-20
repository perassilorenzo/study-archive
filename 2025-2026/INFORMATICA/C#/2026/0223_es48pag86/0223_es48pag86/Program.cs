using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0223_es48pag86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = LeggiNumero("Inserisci il lato delle matrici");
            int[,] A = GenerateMatrix(r);
            int[,] B = GenerateMatrix(r);

            Console.WriteLine(Verifica(A, B));            
        }

        private static string Verifica(int[,] a, int[,] b)
        {
            int r = a.GetLength(0);

            int sommaA = 0;
            int sommaB = 0;

            for (int i = 0; i < r; i++)
            {
                sommaA += a[i, r - 1 - i];   // elemento diagonale secondaria A
                sommaB += b[i, r - 1 - i];   // elemento diagonale secondaria B
            }

            double mediaA = (double)sommaA / r;
            double mediaB = (double)sommaB / r;

            if (mediaA == mediaB) return "Sono uguali";
            return "Non sono uguali";

        }

        private static int[,] GenerateMatrix(int r)
        {
            int[,] matrix = new int[r, r];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0;  j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = LeggiNumero($"Inserisci l'elemento di coordinate {i}, {j}");
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
