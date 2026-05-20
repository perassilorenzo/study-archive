using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicercaSequenziale_OrdinatoSenzaRipetizioni
{
    internal class Program
    {
        /// <summary>
        /// Ricerca sequenziale CASO 3: vettore ordinato senza ripetizioni
        /// </summary>
        /// <param name="vettore">Elementi su cui cercare</param>
        /// <param name="nome">Elemento da ricercare</param>
        /// <returns>Posizione dell'elemento trovato; -1 se non trovato</returns>
        private static int RicercaSequenziale(string[] vettore, string nome)
        {
            int i = 0;

            while (i < vettore.Length && nome.CompareTo(vettore[i]) > 0)
            {
                i++;
            }
            if (vettore[i] == nome)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            const string elemento = "Bianchi";
            string[] v = new string[] { "Bianchi", "Gallo", "Rossi", "Melandri", "Napoli", "Olocco", "Taricco" };

            int pos = RicercaSequenziale(v, elemento);
            if (pos != -1)
            {
                Console.WriteLine($"Nome: {elemento} trovato in posizione {pos}");
            }
            else
            {
                Console.WriteLine($"{elemento} non presente nel vettore");
            }
        }
    }
}