using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_es3pag84
{
    internal class Program
    {
        static Random rnd = new Random();

        /// <summary>
        /// Legge da console un numero intero, opzionalmente solo positivo.
        /// Continua a richiedere l'input finché non viene inserito un numero valido.
        /// </summary>
        /// <param name="messaggio">Messaggio da mostrare all&#39;utente.&lt;/param&gt;
        /// <param name="soloPositivi">Se true, accetta solo numeri maggiori di zero</param>
        /// <returns>Il numero intero inserito dall'utente.</returns>
        static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            int numero;
            bool isCorrect;
            do
            {
                Console.WriteLine(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero intero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere maggiore di 0");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!isCorrect);
            return numero;
        }

        /// <summary>
        /// Riempe un vettore di interi con valori casuali compresi tra 0 e 99.
        /// </summary>
        /// <param name="vettoreA">Array di interi da caricare.</param>
        private static void CaricaVettore(int[] vettoreA)
        {
            for (int i = 0; i < vettoreA.Length; i++)
            {
                vettoreA[i] = rnd.Next(100);
            }
        }

        /// <summary>
        /// Capovolge il vettore sorgente
        /// </summary>
        /// <param name="vettore">Vettore di origine</param>
        private static void InvertiVettore(int[] vettore)
        {
            if (vettore != null)
            {
                int j = vettore.Length - 1;
                int aus;
                for (int i = 0; i < vettore.Length / 2; i++)
                {
                    aus = vettore[i];
                    vettore[i] = vettore[j];
                    vettore[j] = aus;
                    j--;
                }
            }
        }

        /// <summary>
        /// Stampa a video tutti gli elementi di un vettore con il loro indice.
        /// </summary>
        /// <param name="vettoreA">Array di interi da stampare.</param>
        private static void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {vettore[i]}");
            }
        }

        static void Main(string[] args)
        {
            //invertire gli elementi di un vettore A di lunghezza n su se stesso, senza utilizzare alcun vettore ausiliario

            int lunghezzaVettore = LeggiNumero("Inserire le dimensioni del vettore: ");

            int[] vettore = new int[lunghezzaVettore];
            CaricaVettore(vettore);

            Console.WriteLine("\nIl vettore iniziale è: ");
            StampaVettore(vettore);

            InvertiVettore(vettore);
            Console.WriteLine("\nIl vettore finale è: ");
            StampaVettore(vettore);

            Console.ReadKey();
        }
    }
}
