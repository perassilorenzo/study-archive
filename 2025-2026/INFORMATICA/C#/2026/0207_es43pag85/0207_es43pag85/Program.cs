using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207_es43pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 43 pagina 85
            // caricare una matrice quadrata di interi A di ordine (r x r) mettendo tutti 1 nella cornice più esterna, tutti 2 nella seconda cornice, tutti 3 nella terza ecc.

            int n = LeggiNumero("Inserisci il lato della matrice");
            int[,] A = RiempiSpirale(n);

        }

        private static int[,] RiempiSpirale(int n)
        {
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int livello = i;

                    if (j < livello)
                        livello = j;

                    if (n - 1 - i < livello)
                        livello = n - 1 - i;

                    if (n - 1 - j < livello)
                        livello = n - 1 - j;

                    matrix[i, j] = livello + 1;
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
                    Console.WriteLine("Devi inserire valore valido");
                    Console.Clear();
                    Console.ReadKey();
                }
                if (isCorrect && soloPositivi && n > 0)
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