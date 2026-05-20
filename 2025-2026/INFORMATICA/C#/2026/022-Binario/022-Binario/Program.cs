using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Binario
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
        static void Main(string[] args)
        {
            int nDec, resto, numero;
            string nBinario = "";

            nDec = LeggiNumero("Inserisci il numero da convertire in decimale: ");
            numero = nDec;

            while (nDec > 0)
            {
                resto = nDec % 2;
                nBinario = resto + nBinario;
                nDec = nDec / 2;

            }
            Console.WriteLine($"Il numero {numero} in binario vale {nBinario}");
            Console.ReadKey();
        }
    }
}
