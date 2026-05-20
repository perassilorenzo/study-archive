using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _014_FastFood
{
    internal class Program
    {
        static int LeggiNumero(string messaggio)
        {
            bool isCorrect = false;
            int numero;

            do
            {
                Console.Write(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero intero!");
                }
            } while (!isCorrect);

            return numero;
        }

        static void Main(string[] args)
        {
            int nHamburger, nCheeseburger, nMilkshake;

            nHamburger = LeggiNumero("Dimmi quanti hamburger vuoi: ");
            nCheeseburger = LeggiNumero("Dimmi quanti cheeseburger vuoi: ");
            nMilkshake = LeggiNumero("Dimmi quanti milkshake vuoi: ");

            Console.WriteLine($"La spesa totale è: {nHamburger * 3.50 + nCheeseburger * 4.20 + nMilkshake * 1.80}€");

            Console.ReadKey();


        }
    }
}
