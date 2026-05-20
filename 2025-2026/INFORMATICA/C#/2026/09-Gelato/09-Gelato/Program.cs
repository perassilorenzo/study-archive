using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Gelato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double prezzoUnGusto = 1.20;
            const double prezzoDueGusti = 2.00;

            Console.Write("Inserisci il numero di amici invitati: ");
            int amici = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quanti gelati con 1 gusto solo vuoi ordinare? ");
            int gelati1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quanti gelati con 2 gusti vuoi ordinare? ");
            int gelati2 = Convert.ToInt32(Console.ReadLine());

            double spesaTotale = (gelati1 * prezzoUnGusto) + (gelati2 * prezzoDueGusti);

            Console.WriteLine("Spesa totale: " + spesaTotale + " €");

            Console.ReadKey();


        }
    }
}
