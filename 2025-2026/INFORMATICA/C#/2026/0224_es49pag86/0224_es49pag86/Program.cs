using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0224_es49pag86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 49 pagina 86
            // verificare se gli elementi di due matrici di interi A e B entrambe di ordine (r x c) sono uguali

            int r = LeggiNumero("Inserisci il numero di righe delle matrici");
            int c = LeggiNumero("Inserisci il numero di colonne delle matrici");

            int[,] A = GenerateMatrix(r, c);
            int[,] B = GenerateMatrix(r, c);

            Console.WriteLine(Verifica(A, B));
        }

        private static string Verifica(int[,] a, int[,] b)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] != b[i, j]) return "Non sono uguali";
                }
            }

            return "Sono uguali";
        }

        private static int[,] GenerateMatrix(int r, int c)
        {
            int[,] matrix = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
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
