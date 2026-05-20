using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0121_es7pag115
{
    internal class Program
    {
            static string[] Cognomi1 = { "Bianchi", "Ferrero", "Marino", "Rossi" };
            static string[] Nomi1 = { "Luca", "Anna", "Marco", "Giulia" };

            static string[] Cognomi2 = { "Barbero", "Marino", "Russo", "Viano" };
            static string[] Nomi2 = { "Paolo", "Elena", "Sara", "Marta" };
        static void Main(string[] args)
        {
            // esercizio 7 pagina 115
            // sono dati due elenchi di nominativi, entrambi ordinati e con elementi distinti, caricati rispettivamente in quattro vettori chiamati Cognomi1 e Nomi,
            // per il primo elenco, entrambi lunghi n e Cognomi2 e Nomi2, per il secondo elenco, entrambi lunghi m. fondere gli elementi nei vettori Cognomi e Nomi
            // utilizzando l'algoritmo del merge con il metodo di base, eliminando quindi eventuali nominativi duplicati e mantenendo l'ordinamento

            string[] Nomi = new string[Nomi1.Length + Nomi2.Length];
            string[] Cognomi = new string[Cognomi1.Length + Cognomi2.Length];

            MergeBase(Nomi1, Nomi2, Nomi);
            MergeBase(Cognomi1, Cognomi2, Cognomi);

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

        private static void MergeBase(string[] array1, string[] array2, string[] array)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            do
            {
                if (array1[i].CompareTo(array2[j]) > 0)
                {
                    array[k] = array2[j];
                    j++;
                }
                else if (array1[i].CompareTo(array2[j]) == 0)
                {
                    array[k] = array2[j];
                    j++;
                    i++;
                }
                else
                {
                    array[k] = array1[i];
                    i++;
                }

                k++;

            } while (i < array1.Length && j < array2.Length);

            if (i >= array1.Length)
            {
                for(int l = 0; l < array2.Length; l++)
                {
                    array[k++] = array2[l];
                }
            }
            else
            {
                for(int l = 0; l < array1.Length; l++)
                {
                    array[k++] = array1[l];
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
