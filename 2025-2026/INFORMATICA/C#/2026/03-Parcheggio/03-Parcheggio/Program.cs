using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Parcheggio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oraInizio, oraFine, numeroOre;

            do
            {
                Console.Write("Inserire ora di ingresso: ");
                oraInizio = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserire ora di uscita: ");
                oraFine = Convert.ToInt32(Console.ReadLine());

            } while (oraInizio < 0 & oraFine < 0);

            numeroOre = oraFine - oraInizio;

            if (numeroOre == 1)
            {
                Console.WriteLine("Costo: 4€");

            }
            else
            {
                if (numeroOre <= 5)
                {
                    Console.WriteLine("Costo: " + (4 + 3 * (numeroOre - 1)));
                }
                else
                {
                    Console.WriteLine("Costo: " + (4 + 3 * 4 + 2 * (numeroOre - 1)));
                }
            }

            Console.ReadKey();




        }
    }
}
