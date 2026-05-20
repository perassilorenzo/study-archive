using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0204_es15pag115
{
    internal class Program
    {
        static string[] nominativi = new string[] { "Marco Rossi", "Luca Bianchi", "Andrea Verdi", "Paolo Neri", "Giovanni Gallo", "Matteo Conti", "Alessandro Fontana", "Davide Ricci", "Simone Moretti", "Federico Lombardi" };
        static int[] distanzeCm = new int[] { 642, 655, 671, 689, 702, 715, 728, 734, 751, 768 };

        static void Main(string[] args)
        {
            Console.WriteLine("I primi tre classificati sono:");
            StampaPodio();
        }

        private static void StampaPodio()
        {
            int posPrimo = PosMax(int.MaxValue);
            int posSecondo = PosMax(distanzeCm[posPrimo]);
            int posTerzo = PosMax(distanzeCm[posSecondo]);

            Console.WriteLine($"Il primo è {nominativi[posPrimo]} ed ha saltato {distanzeCm[posPrimo]} cm");
            Console.WriteLine($"Il secondo è {nominativi[posSecondo]} ed ha saltato {distanzeCm[posSecondo]} cm");
            Console.WriteLine($"Il terzo è {nominativi[posTerzo]} ed ha saltato {distanzeCm[posTerzo]} cm");
        }

        private static int PosMax(int maxValue)
        {
            int posMax = -1;

            for (int i = 0; i < distanzeCm.Length; i++)
            {
                if (distanzeCm[i] < maxValue && (posMax == -1 || distanzeCm[i] > distanzeCm[posMax]))
                {
                    posMax = i;
                }
            }

            return posMax;
        }
    }
}
