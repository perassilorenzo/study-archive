using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0214_es15pag85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esercizio 45 pagina 115
            //verificare se una matrice quadrata A di interi di ordine (r x c) con r dispari contiene una croce centrata con tutti 1 e 0 in tutte le altre posizioni

            int r = LeggiNumero("Inserisci il numero di righe della matrice", true, true);
            int c = LeggiNumero("Inserisci il numero di colonne della matrice");

            int[,] A = CreateMatrix(r, c);

            Console.WriteLine(CroceCentrata(A, r, c));

        }
        private static string CroceCentrata(int[,] a, int r, int c)
        {
            int centro = r / 2;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ((i == centro || j == centro) && a[i, j] != 1) return "La matrice non contiene una croce centrata di 1";

                    if (i != centro && j != centro && a[i, j] != 0) return "La matrice non contiene una croce centrata di 1";
                }
            }

            return "La matrice contiene una croce centrata di 1";
        }

        private static int[,] CreateMatrix(int r, int c)
        {
            int[,] matrix = new int[r, c];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = LeggiNumero($"Inserisci l'elemento di coordinate {i}, {j} della matrice", true, false, true);
                }
            }

            return matrix;
        }

        private static int LeggiNumero(string v, bool soloPositivi = true, bool numeroDispari = false, bool ZeroUno = false)
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
                if (ZeroUno && n != 0 && n != 1)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire solo 1 o 0");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && n < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere positivo");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && numeroDispari && n % 2 == 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere dispari");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!isCorrect);

            return n;
        }
    }
}
