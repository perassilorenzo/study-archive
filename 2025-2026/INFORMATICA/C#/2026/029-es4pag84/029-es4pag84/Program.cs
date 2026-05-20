using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _029_es4pag84
{
    internal class Program
    {
        static Random rnd = new Random();
        static int maxGlobal;
        static int minGlobal;

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

        private static void CercaMaxMin(int[] vet, int lunghezzaVet, ref int max, ref int min)
        {
            max = int.MinValue;
            min = int.MaxValue;

            for (int i = 0; i < vet.Length; i++)
            {
                if (max < vet[i])
                {
                    max = vet[i];
                }

                if (min > vet[i])
                {
                    min = vet[i];
                }
            }
        }

        private static void CercaMaxMinGlobal(int[] vet)
        {
            maxGlobal = int.MinValue;
            minGlobal = int.MaxValue;
            for (int i = 0; i < vet.Length; i++)
            {
                if (maxGlobal < vet[i])
                {
                    maxGlobal = vet[i];
                }

                if (minGlobal > vet[i])
                {
                    minGlobal = vet[i];
                }
            }
        }

        static void Main(string[] args)
        {
            //determinare il valore maggiore e il valore minore contenuti in un vettore A di lunghezza n

            int lunghezzaVet, max, min;

            lunghezzaVet = LeggiNumero("Inserisci le dimensioni del vettore: ");
            int[] vet = new int[lunghezzaVet];

            CaricaVettore(vet);
            Console.WriteLine("\nVettore: ");
            StampaVettore(vet);

            max = min = 0;
            CercaMaxMin(vet, lunghezzaVet, ref max, ref min);
            CercaMaxMinGlobal(vet);

            Console.WriteLine($"Passaggio per riferimento :\nMax: {max}\nMin: {min}");
            Console.WriteLine($"Passaggio per global:\nMax: {maxGlobal}\nMin: {minGlobal}");

            Console.ReadKey();

        }

    }
}
