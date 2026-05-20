using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _037_es12p84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dopo aver caricato due vettori di interi A e B entrambi di lunghezza n, verificare se le medie dei loro elementi sono uguali

            int lunghezza = LeggiNumero("Inserire la lunghezza del vettore");
            int mediaA = 0;
            int mediaB = 0;

            int[] arrayA = CaricaVettore(lunghezza);
            int[] arrayB = CaricaVettore(lunghezza);

            StampaVettore(arrayA);
            StampaVettore(arrayB);

            mediaA = MediaVettore(arrayA);
            mediaB = MediaVettore(arrayB);

            if (mediaA == mediaB)
            {
                Console.WriteLine("Le medie sono uguali");
            }
            else
            {
                Console.WriteLine("Le medie non sono uguali");
            }

            Console.ReadKey();
        }

        private static int MediaVettore(int[] array)
        {
            int somma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                somma += array[i];
            }
            int media = somma / array.Length;
            Console.WriteLine(media);
            return media;
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
