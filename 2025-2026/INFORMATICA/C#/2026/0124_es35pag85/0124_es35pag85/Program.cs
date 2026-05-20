using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0124_es35pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 34 pagina 85
            // verificare se la somma degli elementi della riga i è uguale alla somma degli elementi della colonna j
            // in una matrice quadrata di interi A di ordine (r x r)
            
            int r = LeggiNumero("Inserisci il valore del lato della matrice");

            int[][] A = RiempiMatrice(r);

            int i = LeggiNumero($"Inserisci la riga da controllare (0 - {r - 1})");
            int j = LeggiNumero($"Inserisci la colonna da controllare (0 - {r - 1})");

            if (Sum(A, r, i, j))
                Console.WriteLine("La somma della riga e della colonna è uguale");
            else
                Console.WriteLine("La somma della riga e della colonna è diversa");
        }

        private static bool Sum(int[][] a, int r, int i, int j)
        {
            int sommaRiga = 0;
            int sommaColonna = 0;

            for (int k = 0; k < r; k++)
            {
                sommaRiga += a[i][k];
            }

            for (int k = 0; k < r; k++)
            {
                sommaColonna += a[k][j];
            }

            return sommaRiga == sommaColonna;
        }

        private static int[][] RiempiMatrice(int r)
        {
            int[][] matrix = new int[r][];

            for (int i = 0; i < r; i++)
            {
                matrix[i] = new int[r];

                for (int j = 0; j < r; j++)
                {
                    matrix[i][j] = LeggiNumero($"Inserisci il valore dell'elemento {i}, {j}");
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