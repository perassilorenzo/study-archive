using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Sconto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prezzo, spesa;
            bool isCorrect;

            Console.OutputEncoding = Encoding.UTF8;

            do
            {
                Console.Write("Inserisci il prezzo: ");
                if (double.TryParse(Console.ReadLine(), out prezzo))    //prova a convertire quello che viene passato dall'utente in un double e mette il risultato della conversione dentro prezzo , il tryparse restiruisce vero o falso. se tryparse restiruisce true allora iscorrect è true...
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido!");
                    Console.ReadKey();      // aspettiamo che venga schiacciato un tasto
                    Console.Clear();        // e puliamo tutto
                }
                if (isCorrect && prezzo <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero maggiore di 0!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            if (prezzo < 100)
            {
                spesa = prezzo - (prezzo * 0.05);
            } else if (prezzo >= 100 && prezzo <300 )
            {
                spesa = prezzo - (prezzo * 0.10);
            } else
            {
                spesa = prezzo - (prezzo * 0.20);
            }

            Console.Write($"L'ammontare con lo sconto equivale  a {spesa}");
            Console.ReadKey();

        }
    }
}
