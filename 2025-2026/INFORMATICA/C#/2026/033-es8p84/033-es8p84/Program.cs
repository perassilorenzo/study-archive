using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_es8p84
{
    internal class Program
    {
        /// <summary>
        /// Legge da console un numero intero, opzionalmente solo positivo.
        /// Continua a richiedere l&#39;input finché non viene inserito un numero valido.
        /// </summary>
        /// <param name="messaggio">Messaggio da mostrare all'utente.</param>
        /// <param name="soloPositivi">Se true, accetta solo numeri maggiori di zero.</param>
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
        /// Stampa a video tutti gli elementi di un vettore con il loro indice.
        /// </summary>
        /// <param name="vettoreSorgente">Array di interi da stampare.</param>
        private static void StampaVettore(int[] vettoreSorgente)
        {
            for (int i = 0; i < vettoreSorgente.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {vettoreSorgente[i]}");
            }
        }

        /// <summary>
        /// Riempe un vettore di interi con valori casuali compresi tra 0 e 99.
        /// </summary>
        /// <param name="vettore1">Array di interi da caricare.</param>
        private static void CaricaVettore(int[] vettore1)
        {
            Random rnd = new Random();

            for (int i = 0; i < vettore1.Length; i++)
            {
                vettore1[i] = rnd.Next(100);
            }
        }
        /// <summary>
        /// Esegue: la somma dei numeri in posizione pari e la somma dei n umeri in posizione dispari
        /// </summary>
        /// <param name="vettore"></param>
        /// <param name="contaPari"></param>
        /// <param name="contaDispari"></param>
        private static void SommaPariDispari(int[] vettore, ref int contaPari, ref int  contaDispari)
        {
            for (int i = 0; i < vettore.Length ; i++)
            {
                if (i % 2  == 0)
                {
                    contaPari += vettore[i];
                }
                else
                {
                    contaDispari += vettore[i];
                }
            }
        }

        static void Main(string[] args, int contaPari)
        {
            // calcolarela somma degli elementi pari e quella degli elementi dispari presenti in un vettore di interi A di lunghezza n

            int n = LeggiNumero("Inserire la dimensione del vettore: ");
            int[] vet = new int[n];
            int contaPari = 0;  
            int contaDispari = 0;

            CaricaVettore(vet);
            StampaVettore(vet);

            SommaPariDispari(vet, ref contaPari, ref contaDispari);

            Console.WriteLine($"La somma degli elementi con indice pari è {contaPari}\nLa somma degli elementi con indice dispari è {contaDispari}");

            Console.ReadKey();
        }

    }
}
