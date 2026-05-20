using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_es1pag84
{
    internal class Program
    {
        static Random rnd = new Random();

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

        private static void CaricaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                vettore[i] = rnd.Next(100);
            }
        }

        /// <summary>
        /// Stampa a video tutti gli elementi di un vettore con il loro indice.
        /// </summary>
        /// <param name="vettoreSorgente">Array di interi da stampare.</param>
        private static void StampaVettore(int[] vettoreSorgente)
        {
            for (int i = 0; i < vettoreSorgente.Length; i++)
            {
                Console.WriteLine($"Elemento { i + 1}: { vettoreSorgente[i]}");
            }
        }

        /// <summary>
        /// Copia gli elementi da un vettore sorgente a un vettore destinazione.
        /// </summary>
        /// <param name="vettoreSorgente">Array di origine</param>
        /// <param> name="vettoreDestinazione">Array di destinazione.</param>
        private static void CopiVettore(int[] vettoreSorgente, int[] vettoreDestinazione)
        {
            for (int i = 0; i < vettoreDestinazione.Length; i++)
            {
                vettoreDestinazione[i] = vettoreSorgente[i];
            }
        }


        static void Main(string[] args)
        {

            //copiare gli elementi di un vettore A di lunghezza n in un vettore B dello stesso tipo, anch'esso di lunghezza n

            int lunghezzaVet = LeggiNumero("Inserisci la dimenzione del vettore: ");

            int[] vettoreSorgente = new int[lunghezzaVet];
            int[] vettoreDestinazione = new int[lunghezzaVet];

            CaricaVettore(vettoreSorgente);
            CopiVettore(vettoreSorgente, vettoreDestinazione);

            Console.WriteLine("\nVettore A: ");
            StampaVettore(vettoreSorgente);
            
            Console.WriteLine("\nVettore B: ");
            StampaVettore(vettoreDestinazione);

            Console.ReadKey();
        }
    }
}
