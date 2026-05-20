using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_es2pag115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // risolvere l'esercizio precedente supponendo che il vettore Classi sia ordinato in ordine crescente

            string[] Nomi = new string[] { "Alessandro", "Andrea", "Anna", "Chiara", "Daniela", "Davide", "Elena", "Federico", "Filippo", "Francesca", "Giacomo", "Giorgia", "Luca", "Marco", "Martina", "Matteo", "Michele", "Sara", "Simone", "Valentina" };
            string[] Cognomi = { "Agosti", "Barbieri", "Bianchi", "Colombo", "Conti", "De Luca", "Esposito", "Ferri", "Fontana", "Galli", "Gentile", "Greco", "Lombardi", "Marini", "Martini", "Moretti", "Ricci", "Rossi", "Russo", "Villa" };
            string[] Classi = { "3A", "3A", "3A", "3A", "3A", "3A", "3B", "3B", "3B", "3B", "3C", "3C", "3C", "3C", "3C", "3D", "3D", "3D", "3E", "3E" };

            Class(Nomi, Cognomi, Classi);
        }
        private static void Class(string[] nomi, string[] cognomi, string[] classi)
        {
            Console.WriteLine("Inserisci la classe da cercare");
            string classe = Convert.ToString(Console.ReadLine());

            bool trovato = false;
            for (int i = 0; i < nomi.Length; i++)
            {
                if (classe == classi[i])
                {
                    Console.WriteLine(nomi[i] + " " + cognomi[i]);
                    trovato = true;
                }
            }

            if (!trovato)
            {
                Console.WriteLine("Nessun studente trovato per la classe inserita");
            }
        }

    }
}
