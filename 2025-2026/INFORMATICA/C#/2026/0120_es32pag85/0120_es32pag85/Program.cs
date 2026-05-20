using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0120_es32pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 32 pagina 85
            // calcolare la somma degli elementi appartenenti alla riga i (con 0 <= i <= r - 1) di una matrice di inter A di ordine (r x c)

            int r = LeggiNumero("Inserisci il valore della riga della matrice");
            int c = LeggiNumero("Inserisci il valore della colonna della matrice");

            int[,] A = new int[r, c];

            Somma(A, r, c);
        }

        private static void Somma(int[,] a, int r, int c)
        {
            int sum = 0;

            for (int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    if(i >= 0 && i <= r - 1)
                    {
                        sum += a[i, j];
                    }
                }
            }

            Console.WriteLine(sum);
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
                    Console.WriteLine("Inserisci un valore valido");
                    Console.Clear();
                    Console.ReadKey();
                }
                if (isCorrect && soloPositivi && n < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Inserisci un numero positivo");
                    Console.Clear();
                    Console.ReadKey();
                }

            } while (!isCorrect);

            return n;
        }
    }
}
