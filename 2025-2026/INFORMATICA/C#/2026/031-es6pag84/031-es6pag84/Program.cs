using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_es6pag84
{
    internal class Program
    {
        static Random rnd = new Random();
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
            for (int i = 0; i < vettore1.Length; i++)
            {
                vettore1[i] = rnd.Next(100);
            }
        }


        private static bool IsOrderedGrowingUp(int[] vet)
        {
            bool isUp = true;
            int i = 0;

            while (isUp && i != vet.Length - 1)
            {
                if (vet[i] > vet[i + 1])
                {
                    isUp = false;
                }
                i++;
            }
            return isUp;
        }

        private static bool IsOrderedGrowingDown(int[] vet)
        {
            bool isLower = true;
            int i = 0;

            while ( isLower && i != vet.Length - 1)
            {
                if (vet[i] < vet[i + 1])
                {
                    isLower = false;
                }
                i++;
            } return isLower;
        }
        static void Main(string[] args)
        {
            //verificare se gli elementi di un vettore di interi A di lunghezza n sono ordinati, specificando se l'ordinamento è crescente o descrescente

            int dimensioneVet;
            dimensioneVet = LeggiNumero("Inserisci la dimensione del vettore: ");

            int[] vet = new int[dimensioneVet];
            CaricaVettore(vet);

            Console.WriteLine("Il vettore è: ");
            StampaVettore(vet);

            if (IsOrderedGrowingUp(vet))
            {
                Console.WriteLine("Il vettore è ordinato ed è crescente!");
            }
            else if (IsOrderedGrowingDown(vet))
            {
                Console.WriteLine("Il vettore è ordinato ed è decrescente!");
            }
            else
            {
                Console.WriteLine("Il vettore non è ordinato!");
            }

            Console.ReadKey();

        }
    }
}
