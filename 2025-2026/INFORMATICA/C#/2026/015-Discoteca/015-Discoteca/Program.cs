using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Discoteca
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
            int nRagazzi, nRagazze;
            double spesaTotale;

            nRagazzi = LeggiNumero("Inserisci il numero dei ragazzi: ");
            nRagazze = LeggiNumero("Inserisci il numero dei ragazze: ");

            Console.WriteLine($"La spesa totale è {nRagazzi * 12 + nRagazze * 12 * 0.7}€");
            Console.ReadKey();
        }
    }
}
