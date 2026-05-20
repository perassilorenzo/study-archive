using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0204_es13pag115
{
    internal class Program
    {
        static string[] caseEditrici = { "Bompiani", "Bompiani", "Bompiani", "Feltrinelli", "Garzanti", "Mondadori", "Mondadori", "Mondadori", "Newton Compton", "Salani" };
        static string[] titoli = { "Il nome della rosa", "Il signore degli anelli", "Il piccolo principe", "Orgoglio e pregiudizio", "I promessi sposi", "1984", "Il codice Da Vinci", "Fahrenheit 451", "La coscienza di Zeno", "Harry Potter e la pietra filosofale" };
        static string[] generi = { "Giallo storico", "Fantasy", "Narrativa", "Romanzo", "Romanzo storico", "Fantascienza", "Thriller", "Fantascienza", "Narrativa", "Fantasy" };
        
        static void Main(string[] args)
        {
            // esercizio 13 pagina 115
            // risolvere l'esercizio precedente supponendo che il vettore CaseEditrici sia ordiato in ordine crescente

            Console.WriteLine("Inserire il genere dei libri da contare ");
            string genere = Console.ReadLine();

            Console.WriteLine("Inserire la casa editrice dei libri da cercare");
            string casaEditrice = Console.ReadLine();

            int i = 0;

            while (i < caseEditrici.Length && caseEditrici[i].CompareTo(casaEditrice) < 0)
            {
                i++;
            }

            Console.WriteLine($"Il conteggio dei libri di genere {genere} e casa editrice {casaEditrice} è {i}");
        }
    }
}
