using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_es13p84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verificare se gli elementi di un vettore A di lunghezza n sono speculari

            int lunghezza = LeggiNumero("Inserire la lunghezza del vettore");

            int[] array = CaricaVettore(lunghezza);

            VettoreSpeculare(array);

            Console.ReadKey();
        }


        /// <summary>
        /// Questa funzione dice se il vettore dato in ingresso è speculare o meno
        /// </summary>
        /// <param name="array">vettore dato ingresso</param>
        private static void VettoreSpeculare(int[] array)
        {
            bool isSpeculare = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array[array.Length - 1 - i])
                {
                   isSpeculare = true; 
                }
                else
                {
                    isSpeculare = false;
                    break;
                }
            }

            if (isSpeculare == true)
            {
                Console.WriteLine("Il vettore è speculare");
            }
            else
            {
                Console.WriteLine("Il vettore non è speculare");
            }
        }

        private static void StampaVettore(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {array[i]}");
            }
        }

        private static int[] CaricaVettore(int lunghezza)
        {

            int[] array = new int[lunghezza];

            for (int i = 0; i < lunghezza; i++)
            {
                array[i] = LeggiNumero($"Inserire l'elemento numero {i+1} del vettore");
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

