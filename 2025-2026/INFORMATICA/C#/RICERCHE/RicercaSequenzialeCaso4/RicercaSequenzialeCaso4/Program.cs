using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RicercaSequenziale_OrdinatoRipetizioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] v = new string[] { "Bianchi", "Gallo", "Rossi", "Rossi", "Napoli", "Olocco", "Taricco" };
            //int[] vPos = new int[v.Length];

            //Console.WriteLine("Inserisci il nome da cercare: ");
            //string nome = Console.ReadLine();

            //int nElementi = RicercaSequenziale(v, vPos, nome);

            //if (nElementi == 0)
            //{
            //    Console.WriteLine($"Nome: {nome} non presente");
            //}
            //else
            //{
            //    Console.WriteLine($"Nome: {nome} trovato nelle seguente posizioni: \n");
            //    for (int i = 0; i < nElementi; i++)
            //    {
            //        Console.Write(vPos[i] + " ");
            //    }

            //}

            //Console.ReadKey();

            string[] v = new string[] { "Bianchi","Neri", "Bruni", "Neri", "Pecollo", "Ratti", "Stoppa"};
            string element = "Neri";
            int[] vPos = new int[v.Length];

            int nElement = RicercaSequenzialeCaso4(v, vPos, element);

            Console.WriteLine($"Sono stati trovati {nElement} nomi uguali a {element}");

            for (int i = 0; i < nElement; i++) { Console.Write(vPos[i] + " "); }
        }
        /// <summary>
        /// Ricerca sequenziale per array ordinato e con ripetizioni
        /// </summary>
        /// <param name="array">Vettore su cui cercare</param>
        /// <param name="arrayPos">Vettore delle posizioni</param>
        /// <param name="element">element da cercare</param>
        /// <returns>Quante volte compare nel array</returns>
        private static int RicercaSequenziale(string[] array, int[] arrayPos, string element)
        {
            int nElementi = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    arrayPos[nElementi] = i;
                    nElementi++;

                }
            }

            return nElementi;
        }

        private static int RicercaSequenzialeCaso4(string[] array, int[] arrayPos, string element)
        {
            bool superato = false;
            int i = 0, j = 0;

            while(i  < array.Length && !superato)
            {
                if(array[i] == element)
                {
                    arrayPos[j] = i;
                    j++;
                }
                else
                {
                    if (element.CompareTo(array[i]) < 0)
                    {
                        superato = true;
                    }
                }
                i++;
            }
            return j;
        }
    }
}