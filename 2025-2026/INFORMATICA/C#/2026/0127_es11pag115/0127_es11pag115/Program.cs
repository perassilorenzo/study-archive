using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0127_es11pag115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 11 pagina 115
            // risolvere l'esercizio precedente supponendo che le informazioni sui DVD diano ordinate in base all'anno di pubblicazione

            int[] anni = { 2008, 2010, 2010, 2011, 2011, 2012, 2013, 2014 };
            string[] titoli = { "Il Cavaliere Oscuro", "Inception", "Shutter Island", "Drive", "Midnight in Paris", "The Avengers", "Gravity", "Interstellar" };
            string[] registi = { "Christopher Nolan", "Christopher Nolan", "Martin Scorsese", "Nicolas Winding Refn", "Woody Allen", "Joss Whedon", "Alfonso Cuarón", "Christopher Nolan" };

            Console.Write("Inserisci il nome del regista");
            string nomeRegista = Console.ReadLine();

            Ricerca(anni,  titoli, registi, nomeRegista);

        }

        private static void Ricerca(int[] anni, string[] titoli, string[] registi, string nomeRegista)
        {

            bool trovato = false;

            for (int i = 0; i < anni.Length; i++)
            {
                if (anni[i] >= 2010 && anni[i] <= 2012 && registi[i] == nomeRegista)
                {
                    Console.WriteLine(titoli[i] + " " + anni[i] + "\n");
                    trovato = true;
                }
            }

            if (!trovato)
            {
                Console.WriteLine("Nessun DVD trovato");
            }
        }
    }
}
