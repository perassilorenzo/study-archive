using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0110_Multa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double multa, costo;
            int giorni;
            bool isCorrect = false; 


            Console.OutputEncoding = Encoding.UTF8;  // forza endecoding che serve per mettere in output € al posto di ?
            do
            {
            Console.Write("Inserisci l'ammontare della multa: ");
                if (double.TryParse(Console.ReadLine(), out multa))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && multa <= 0 )
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero maggiore di 0!");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!isCorrect);

            do
            {
                Console.Write("Inserisci il numero di giorni: ");
                if (int.TryParse(Console.ReadLine(), out giorni))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && giorni <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero maggiore di 0!");
                    Console.ReadKey();
                    Console.Clear();
                }


            } while (!isCorrect);

            if (giorni > 14) costo = multa + (multa * 0.3);
            else if (giorni > 7) costo = multa + (multa * 0.1);
            else costo = multa;

            Console.WriteLine("L'ammontare da pagare è pari a: " + costo + "€");
            Console.ReadKey();
        }
    }
}
