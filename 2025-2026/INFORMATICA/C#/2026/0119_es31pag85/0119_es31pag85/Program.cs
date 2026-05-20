using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0119_es31pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 31 pagina 85
            // calcolare la somma degli elementi appartenenti alla cornice più esterna di una matrice di interi A di ordine (r x c)

            int r = LeggiNumero("Inserisci la quantità di righe");
            int c = LeggiNumero("Inserisci la quantità di colonne");

            int[,] A = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    A[i, j] = LeggiNumero($"Inserisci l'elemento a coordinate {i + 1} {j + 1}");
                }
            }

            Somma(A, r, c);
        }

        private static void Somma(int[,] a, int r, int c)
        {
            int somma = 0;

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i == 0 || i == r - 1 || j == 0 || j == c - 1)
                    {
                        somma += a[i, j];
                    }
                }
            }

            Console.WriteLine($"La somma della cornice esterna è: {somma}");
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
                    Console.WriteLine("Inserire un valore valido");
                    Console.Clear();
                    Console.ReadKey();
                }
                if (soloPositivi && isCorrect && n < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero positivo");
                    Console.Clear();
                    Console.ReadKey();
                }
            } while (!isCorrect);

            return n;
        }
    }
}
