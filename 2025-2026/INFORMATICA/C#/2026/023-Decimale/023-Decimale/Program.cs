using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_Decimale
{
    internal class Program
    {

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

        private static bool ControllaNBinario(string nBinario)
        {
            for (int i = 0; i < nBinario.Length; i++)
            {
                if (nBinario[i] != '0' && nBinario[i] != '1')
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string nBinario = "";
            bool isCorrect;

            do
            {
                Console.Write("Inserire il numero binario da convertire in decimale: ");
                nBinario = Console.ReadLine();
                isCorrect = ControllaNBinario(nBinario);
                if (!isCorrect)
                {
                    Console.WriteLine("Il numero inserito non è valido !"),
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!ControllaNBinario(nBinario));

        }
    }
}
