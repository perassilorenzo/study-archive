using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _035_es10p84
{
    internal class Program
    {
        static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            int numero;
            bool isCorrect;

            do
            {
                Console.WriteLine(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero valido!");
                    Console.ReadKey();
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
        private static void ElementiUguali(int[] vet)
        {
            bool isCorrect = true;
            int i = 1;

            //soluzione 1
            while (vet[i] == vet[0])
            {
                i++;
            }

            //soluzione 2
            while(isCorrect && i < vet.Length)
            {
                if (vet[i] != vet[0])
                {
                    isCorrect = false; 
                }
                i++;
            }
            if (isCorrect)
            {
                Console.WriteLine("Gli elementi sono tutti uguali");
            }
            else
            {
                Console.WriteLine("Gli elementi non sono uguali");
            }
        }


        static void Main(string[] args)
        {
            // verificare se gli elementi di un vettore A di lunghezza n sono tutti uguali tra loro 

            int n = LeggiNumero("Inserire le dimensioni del vettore: ");
            int[] vet = new int[n];

            CaricaVettore(vet);
            StampaVettore(vet);

            ElementiUguali(vet);

            Console.ReadKey();

        }

    }
}
