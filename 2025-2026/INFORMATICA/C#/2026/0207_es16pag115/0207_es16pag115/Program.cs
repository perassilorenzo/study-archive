using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207_es16pag115
{
    internal class Program
    {
        static string[] nominativi = new string[] { "Marco Rossi", "Luca Bianchi", "Andrea Verdi", "Paolo Neri", "Giovanni Gallo", "Matteo Conti", "Alessandro Fontana", "Davide Ricci", "Simone Moretti", "Federico Lombardi" };
        static int[] distanzeCm = new int[] { 642, 655, 671, 689, 702, 715, 728, 734, 751, 768 };
     
        static void Main(string[] args)
        {
            // esercizio 16 pagina 115
            // risolvere l'esercizio precedente supponendo che invece possano esistere dei pari merito

            Console.WriteLine("I primi tre classificati (con eventuali pari merito) sono:");
            StampaPodio();
        }

        private static void StampaPodio()
        {
            int posto = 1;

            for (int k = 0; k < 3; k++)
            {
                int max = Max(distanzeCm);
                if (max == int.MinValue) break;

                Console.Write($"Posto {posto}: ");
                for (int i = 0; i < distanzeCm.Length; i++)
                {
                    if (distanzeCm[i] == max)
                    {
                        Console.Write($"{nominativi[i]} con {distanzeCm[i]} cm");
                        distanzeCm[i] = int.MinValue;
                    }
                }
                Console.WriteLine();
                posto++;
            }
        }

        private static int Max(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
    }
}