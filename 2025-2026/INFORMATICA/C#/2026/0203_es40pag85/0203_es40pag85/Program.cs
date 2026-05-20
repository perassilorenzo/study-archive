using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0203_es40pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 40 pagina 85
            // verificare se una matrice quadrata di interi A di ordine (r x r) è speculare

            int n = LeggiNumero("Inserisci il lato della matrice");
            int[,] A = RiempiMatrice(n);

            if (Verifica(A, n))
            {
                Console.WriteLine("La matrice è speculare");
            }
            else
            {
                Console.WriteLine("La matrice non è speculare");
            }
        }

        private static bool Verifica(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i,j] != a[j,i]) return false;
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
                    matrix[i, j] = LeggiNumero($"Inserisci l'elemento di coordinate {i} ; {j}");
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
