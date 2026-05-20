using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0121_es8pag115
{
    internal class Program
    {
        static string[] Cognomi1 = { "Bianchi", "Ferrero", "Marino", "Rossi" };
        static string[] Nomi1 = { "Luca", "Anna", "Marco", "Giulia" };

        static string[] Cognomi2 = { "Barbero", "Marino", "Russo", "Viano" };
        static string[] Nomi2 = { "Paolo", "Elena", "Sara", "Marta" };

        static void Main(string[] args)
        {
            // esercizio 8 pagina 115

            string[] Nomi = new string[Nomi1.Length + Nomi2.Length];
            string[] Cognomi = new string[Cognomi1.Length + Cognomi2.Length];

            MergeTappo(Nomi1, Nomi2, Nomi);
            MergeTappo(Cognomi1, Cognomi2, Cognomi);

            PrintArray(Nomi1);
            Console.WriteLine();
            PrintArray(Nomi2);
            Console.WriteLine();
            PrintArray(Nomi);
            Console.WriteLine();
            PrintArray(Cognomi1);
            Console.WriteLine();
            PrintArray(Cognomi2);
            Console.WriteLine();
            PrintArray(Cognomi);
            Console.WriteLine();

        }
        private static void MergeTappo(string[] array1, string[] array2, string[] array)
        {
            array1[array1.Length] = "Zz";        
            array2[array2.Length] = "Zz";

            int i = 0;
            int j = 0;

            for (int k = 0; k < (array1.Length + array2.Length - 1); k++)
            {
                if (array1[i].CompareTo(array2[j]) > 0)
                {
                    array[k] = array2[j];
                    j++;
                }
                else
                {
                    array[k] = array1[i];
                    i++;
                }
            }
        }

        private static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

        }
    }
}
