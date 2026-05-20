using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_es7p84
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

        private static bool CercaNumero(int[] vettore, int numero)
        {
            bool trovato = false;
            int i = 0;

            while (i < vettore.Length && !trovato)
            {
                if (vettore[i] == numero)
                {
                    trovato = true;
                }
                else i++;
            }

            return trovato;
        }
        private static int ContaNumero(int[] vettore, int numero)
        {
            int conta = 0;

            for(int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] == numero)
                {
                    conta++;
                }
            }

            return conta;
        }

        static void Main(string[] args)
        {
            int n = LeggiNumero("Dimensione vettore: ");
            int[] vet = new int[n];

            int x = LeggiNumero("Inserisci il numero da cercare: ");

            CaricaVettore(vet);
            StampaVettore(vet);

            if (CercaNumero(vet, x))
            {
                Console.WriteLine($"Il numero {x} è presente {ContaNumero(vet, x)} volta/e nel vettore");
            }
            else
            {
                Console.WriteLine("Non è stato trovato nessun valore");
            }

            Console.ReadKey();
        }
    }
}
