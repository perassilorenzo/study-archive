using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207_es14pag115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 14 pag 115
            // risolvere l'esercizio precedente supponendo che anche il vettore Genere sia ordinato in ordine crescente

            string[] titoli = { "Orgoglio e Pregiudizio", "Il Nome della Rosa", "Il Signore degli Anelli", "Sherlock Holmes", "1984" };
            string[] caseEditrice = { "Adelphi", "Bompiani", "Feltrinelli", "Mondadori", "Zanichelli" };
            string[] generi = { "Avventura", "Fantasy", "Giallo", "Romanzo", "Storico" };

            Console.WriteLine("Inserisci la casa editrice da ricercare");
            string casaEditrice = Console.ReadLine();

            Console.WriteLine("Inserisci il genere da ricerca");
            string genere = Console.ReadLine();

            int count = 0;

            Verifica(titoli, caseEditrice, casaEditrice, generi, genere, ref count);
            Console.WriteLine(count);

        }

        private static void Verifica(string[] titoli, string[] caseEditrice, string casaEditrice, string[] generi, string genere, ref int count)
        {
            for (int i = 0; i < titoli.Length; i++)
            {
                if (caseEditrice[i] == casaEditrice && generi[i] == genere)
                {
                    count++;
                }
            }
        }
    }
}
