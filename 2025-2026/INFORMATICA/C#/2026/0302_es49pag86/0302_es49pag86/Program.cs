using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302_es49pag86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 49 pagina 86 ottimizzato
            // verificare se gli elementi di due matrici di interi A e B entrambe di ordine (r x r) sono uguale utilizzando 2 cicli while

            int r = ReadInteger("Inserisci il lato delle matrici");
            int[,] A = GenerateMatrix(r);
            int[,] B = GenerateMatrix(r);

            Console.WriteLine(Verify(A, B));
        }

        private static string Verify(int[,] a, int[,] b)
        {
            int i = 0, j = 0;
            bool leave = false;

            while (i < a.GetLength(0) && !leave)
            {
                j = 0;
                while (j < a.GetLength(1) && !leave)
                {
                    if (a[i, j] != b[i, j]) leave = true;
                    j++;
                }
                i++;
            }

            if (leave) return "Non sono uguali";
            return "Sono uguali";
        }

        private static int[,] GenerateMatrix(int r)
        {
            int[,] matrix = new int[r, r];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = ReadInteger($"Inserisci l'elemento in coordinate {i}, {j} della matrice");
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
