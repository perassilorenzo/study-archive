using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Fattoriale
{
    internal class Program
    {
        static ulong fattoriale = 1;

        /// <summary>
        /// legge un numero da tastiera e lo restituisce, se valido.
        /// </summary>
        /// <param name="messaggio">Messaggio visualizzato</param>
        /// <param name="soloPositivi">[opsionale] Se true accetta solo positivi</param>
        /// <returns>Numero inserito dalla tastiera</returns>
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
                else if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero intero!");
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido!");
                    Console.ReadKey();      // aspettiamo che venga schiacciato un tasto
                    Console.Clear();        // e puliamo tutto
                }
                if (isCorrect && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero maggiore di 0!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return numero;
        }
        private static void CalcolaFattoriale(ulong n)
        {
            while (n > 1)
            {
                fattoriale = fattoriale * n;
                n--;
            }
        }

        static void Main(string[] args)
        {
            ulong n;

            n = Convert.ToUInt64(LeggiNumero("Devi inserire un numero di cui vuoi fare il fattoriale: "));
            string nS = Console.ReadLine();
            n = Convert.ToUInt64(nS);
            CalcolaFattoriale(n);
            Console.WriteLine($"Il fattoriale di {n} vale {fattoriale}");

            Console.ReadKey();

        }
    }
}
