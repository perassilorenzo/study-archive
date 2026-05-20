using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052_es3pag115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // risolvere l'esercizio precedente visualizzando l'elenco studenti trovati ordinati per cognome e, in caso di parità, per il nome

            string[] Nomi = new string[] { "Alessandro", "Andrea", "Anna", "Chiara", "Daniela", "Davide", "Elena", "Federico", "Filippo", "Francesca", "Giacomo", "Giorgia", "Luca", "Marco", "Martina", "Matteo", "Michele", "Sara", "Simone", "Valentina" };
            string[] Cognomi = { "Agosti", "Barbieri", "Bianchi", "Colombo", "Conti", "De Luca", "Esposito", "Ferri", "Fontana", "Galli", "Gentile", "Greco", "Lombardi", "Marini", "Martini", "Moretti", "Ricci", "Rossi", "Russo", "Villa" };
            string[] Classi = { "3A", "3A", "3A", "3A", "3A", "3A", "3B", "3B", "3B", "3B", "3C", "3C", "3C", "3C", "3C", "3D", "3D", "3D", "3E", "3E" };
            int[] vPos = new int[Nomi.Length];

            string[] cognomiNomi = new string[Nomi.Length];

            Console.WriteLine("Inserisci la classe da cercare: ");
            string nome = Console.ReadLine().ToUpper();

            int nElementi = RicercaSequenziale(Classi, vPos, nome);

            UnisciArray(Cognomi, Nomi, cognomiNomi);
            OrderArray(Cognomi, Nomi, cognomiNomi, vPos[0], nElementi + vPos[0]);
        }
        /// <summary>
        /// unisce, ad uno ad uno, 2 vettori di stringhe in un terzo vettore di stringhe
        /// </summary>
        /// <param name="vettore1"></param>
        /// <param name="vettore2"></param>
        /// <param name="vettore"></param>
        private static void UnisciArray(string[] vettore1, string[] vettore2, string[] vettore)
        {
            for (int i = 0; i < vettore1.Length; i++)
            {
                vettore[i] = vettore1[i] + " " + vettore2[i];
            }
        }

        /// <summary>
        /// ordina in modo crescente i 2 vettori; a parità di elementi sul primo vettore verifica il secondo
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <param name="array3"></param>
        /// <param name="main"> posizione iniziale della porzione di vettore da ordinare </param>
        /// <param name="end"> posizione finale della porzione di vettore da ordinare </param>
        private static void OrderArray(string[] array1, string[] array2, string[] array3, int main, int end)
        {
           // ordino array3 e contemporaneamente vado a sistemare anche array1 e array2
        }
    }
}
