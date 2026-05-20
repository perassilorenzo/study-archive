using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Media
{
    internal class Program
    {
        /// <summary>
        /// Legge da console un numero intero, opzionalmente solo positivo.
        /// Continua a richiedere l'input finché non viene inserito un numero valido.
        /// </summary>
        /// <param name="messaggio">Messaggio da mostrare all&#39;utente.&lt;/param&gt;
        /// <param name="soloPositivi">Se true, accetta solo numeri maggiori di zero</param>
        /// <returns>Il numero intero inserito dall'utente.</returns>

        static int LeggiNumero(string messaggio)
        {
            int numero;
            bool isCorrect;

            do
            {
                Console.Write(messaggio);
                string input = Console.ReadLine();
                isCorrect = int.TryParse(input, out numero);

                if (!isCorrect)
                {
                    Console.WriteLine("Devi inserire un numero intero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (numero <= 0)
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
            int nNumeri = LeggiNumero("Di quanti numeri vuoi fare la media? ");
            double somma = 0;

            for (int i = 0; i < nNumeri; i++)
            {
                somma += LeggiNumero($"Inserisci il numero {i + 1}: ");
            }

            Console.WriteLine($"La media dei numeri è = {somma / nNumeri}");
        }
    }
}
