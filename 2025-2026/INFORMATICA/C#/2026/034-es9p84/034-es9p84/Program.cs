using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_es9p84
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
        /// Caricamento casuale degli elementi di un vettore
        /// </summary>
        /// <param name="vettore1">Array di interi da caricare.</param>
        /// <param name="tipologia">n: >= 0, p: > 0, z: </param>
        private static void CaricaVettore(int[] vettore1, char tipologia = 'n')
        {
            Random rnd = new Random();

            for (int i = 0; i < vettore1.Length; i++)
            {
                switch (tipologia)
                {
                    case 'n':
                        vettore1[i] = rnd.Next(100);
                        break;
                    case 'p':
                        vettore1[i] = rnd.Next(99) + 1;
                        break;
                    case 'z':
                        vettore1[i] = rnd.Next(199) - 99;
                        break;
                    
                }
            }
        }

        private static void ContaPositiviNegativi(int[] vet, ref int contaPositivi, ref int contaNegativi)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] > 0)
                {
                    contaPositivi++;
                }
                else if (vet[i] < 0)
                {
                    contaNegativi++;
                }
                
            }
        }

        static void Main(string[] args)
        {
            // contare il numero di elementi positivi d di lementi negativi preseenti in un vettroe di interei A di lunghezza n

            int n = LeggiNumero("Dimensione del vettore: ");
            int[] vet = new int[n];
            int contaPositivi = 0;
            int contaNegativi = 0;


            CaricaVettore(vet, 'z');
            StampaVettore(vet);

            ContaPositiviNegativi(vet, ref contaPositivi, ref contaNegativi);

            Console.WriteLine($"Nel vettore ci sono {contaPositivi} numeri positivi e {contaNegativi} numeri negativi");

            Console.ReadKey();
        }

    }
}
