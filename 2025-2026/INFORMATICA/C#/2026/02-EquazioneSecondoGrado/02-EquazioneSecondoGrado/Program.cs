using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02_EquazioneSecondoGrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta, x1, x2;

            do
            {
                Console.Clear();
                Console.Write("Inserisci il coefficente a (Maggiore di 0): ");
                a = Convert.ToInt32(Console.ReadLine());

            } while (a != 0);

            Console.Write("Inserisci il coefficente b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserisci il coefficente c: ");
            c = Convert.ToInt32(Console.ReadLine());

            delta = b * b - (4 * a * c);

            if (delta < 0)
            {
                Console.WriteLine("Impossibile");
            }

            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                if (x1 == x2)
                {
                    Console.WriteLine("L'equazione ha una soluzione che è: {0}", x1);
                }

                else
                {
                    Console.WriteLine("L'equazione ha due soluzioni che sono: {0} {1}", x1, x2);
                }
            }

            Console.ReadKey();
        }
    }
}
