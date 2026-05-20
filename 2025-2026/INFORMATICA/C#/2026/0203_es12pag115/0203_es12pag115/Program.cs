using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0203_es12pag115
{
    internal class Program
    {
        static string[] titoli = { "Il nome della rosa", "1984", "Il signore degli anelli", "Harry Potter e la pietra filosofale", "Il piccolo principe", "La coscienza di Zeno", "Il codice Da Vinci", "Orgoglio e pregiudizio", "I promessi sposi", "Fahrenheit 451" };
        static string[] generi = { "Giallo storico", "Fantascienza", "Fantasy", "Fantasy", "Narrativa", "Narrativa", "Thriller", "Romanzo", "Romanzo storico", "Fantascienza" };
        static string[] caseEditrici = { "Bompiani", "Mondadori", "Bompiani", "Salani", "Bompiani", "Newton Compton", "Mondadori", "Feltrinelli", "Garzanti", "Mondadori" };
        
        static void Main(string[] args)
        {
            // esercizio 12 pagina 115
            // le informazioni riguardanti i libri in biblioteca sono registrate in una serie di vettori di lunghezza n. contare il numero di libri in biblioteca che trattano un genere di cui si fornisce in ingresso la descrizione, pubblicati da una casa editrice di cui fornisca il nome in ingresso

            Console.WriteLine("Inserire il genere dei libri da contare ");
            string genere = Console.ReadLine();

            Console.WriteLine("Inserire la casa editrice dei libri da cercare");
            string casaEditrice = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < titoli.Length; i++)
            {
                if (generi[i] == genere)
                {
                    if (caseEditrici[i] == casaEditrice)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Il conteggio dei libri di genere {genere} e casa editrice {casaEditrice} è {count}");
        }
    }
}
