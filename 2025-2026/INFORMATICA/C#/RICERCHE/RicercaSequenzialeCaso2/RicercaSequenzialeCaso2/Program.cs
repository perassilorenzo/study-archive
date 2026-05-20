using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicercaSequenzialeCaso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ricerca sequenziale caso 2 con il for a pagina 92 con ripetizioni

            string[] array = new string[] { "Rossi", "Gallo", "Rossi", "Gallo", "Devirgiolio", "Melandri", "Fabbri", "Chiera" };
            int[] arrayPosition = new int[array.Length];   

            Console.Write("Inserisci un element da cercare");
            string element = Console.ReadLine();

            int nElementi = RicercaSequenziale()

            if (RicercaSequenziale(array, arrayPosition, element) == 0)
            {
                Console.WriteLine($"Nome: {element} NON presente!");
            }
            else
            {
                Console.WriteLine($"Nome: {element} trovato nelle seguenti posizioni:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(" " + arrayPosition[i]);
                }
            }
            
        }
        /// <summary>
        /// ricerca sequenziale per array disordinato e con ripetizioni 
        /// </summary>
        /// <param name="array">vettore su cui cercare</pdsfaram>
        /// <param name="arrayPosition">vettore delle posizioni</param>
        /// <param name="element">elemento da cercare</param>
        /// <returns> le volte che compare all'interno del vettore </returns>
        private static int RicercaSequenziale(string[] array, int[] arrayPosition, string element)
        {
            int nElements = 0;

            for(int i = 0; i < array.Length;)
            {
                if (array[i] == element)
                {
                    arrayPosition[nElements] = i;
                    nElements++;
                }
            }

            return nElements;   
        }
    }
}
