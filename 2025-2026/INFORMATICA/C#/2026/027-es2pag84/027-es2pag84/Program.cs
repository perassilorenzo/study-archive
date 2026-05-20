using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _027_es2pag84
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
        /// Copia gli elementi di un vettore sorgente in un vettore destinazione invertendo l'ordine.
        /// </summary>
        /// <param name="vettoreA">Array di origine.</param>
        /// <param name="vettoreB">Array di destinazione.</param>
        private static void CopiaInvertiVettore(int[] vettoreA, int[] vettoreB)
        {
            int j = vettoreA.Length - 1;
            for (int i = 0; i < vettoreB.Length; i++)
            {
                vettoreB[j] = vettoreA[i];
                j--;
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
                Console.WriteLine($"Elemento { i + 1}: {vettore[i]}");
            }
        }

        static void Main(string[] args)
        {
            //copiare gli elementi di un vettore A di lunghezza n invertendoli in un vettore B dello stesso tipo, anch'esso di lunghezza n

            int lunghezzaVettore = LeggiNumero("Inserisci le dimensioni del vettore: ");

            int[] vettoreA = new int[lunghezzaVettore];
            int[] vettoreB = new int[lunghezzaVettore];

            CaricaVettore(vettoreA);
            CopiaInvertiVettore(vettoreA, vettoreB);

            Console.WriteLine("\nVettore A: ");
            StampaVettore(vettoreA);

            Console.WriteLine("\nVettore B: ");
            StampaVettore(vettoreB);

            Console.ReadKey();

        }
    }
}
