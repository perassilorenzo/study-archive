///using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_es11p84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dopo aver caricato due vettori A e B entrambi di lunghezza n, copiare in un vettore C gli elementi di A e B che occupano la stessa posizione e sono quelli uguali

            int lunghezza = LeggiNumero("Inserire la lunghezza dei vettori");
            int[] arrayA = CaricaVettore(lunghezza);
            int[] arrayB = CaricaVettore(lunghezza);
            int[] arrayC = new int[lunghezza];

            StampaVettore(arrayA);
            StampaVettore(arrayB);
            
            for (int i = 0; i < lunghezza; i++)
            {
                if (arrayA[i] == arrayB[i])
                {
                    arrayC[i] = arrayA[i];
                }
            }

            StampaVettore(arrayC);
        }

        private static void StampaVettore(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {array[i]}");
            }
        }

        static Random rnd = new Random();
        private static int[] CaricaVettore(int lunghezza)
        {

            int[] array = new int[lunghezza];

            for (int i = 0; i < lunghezza; i++)
            {
                array[i] = rnd.Next(10);
            }

            return array;
        }


        private static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            bool isCorrect = true;
            int numero;

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
                    Console.WriteLine("Devi inserire un numero valido");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (soloPositivi && isCorrect && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero maggiore di 0");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!isCorrect);
                return numero;
        }


    }
}
