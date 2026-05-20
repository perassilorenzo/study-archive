using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0127_es10pag115
{
    internal class Program
    {
        static Random rnd = new Random();
        /// <summary>
        /// Legge da console un numero intero, opzionalmente solo positivo.
        /// Continua a richiedere l'input finché non viene inserito un numero valido.
        /// </summary>
        /// <param name="messaggio">Messaggio da mostrare all'utente.</param>
        /// <param name="soloPositivi">Se true, accetta solo numeri maggiori di zero.</param>
        /// <returns>Il numero intero inserito dall'utente.</returns>
        static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            int numero;
            bool isCorrect;

            do
            {
                Console.WriteLine(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero intero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere maggiore di 0");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (!isCorrect);
            return numero;
        }
        static string[] titoli = new string[]
        {
        "Il Signore degli Anelli: La Compagnia dell'Anello",
        "Inception",
        "Il Gladiatore",
        "Forrest Gump",
        "Matrix",
        "Titanic",
        "Interstellar",
        "Pulp Fiction",
        "La vita è bella",
        "Il Cavaliere Oscuro"
        };

        static int[] anniPubblicazione = new int[]
        {
        2001,
        2010,
        2000,
        1994,
        1999,
        1997,
        2014,
        1994,
        1997,
        2008
        };

        static string[] registi = new string[]
        {
        "Peter Jackson",
        "Christopher Nolan",
        "Ridley Scott",
        "Robert Zemeckis",
        "Lana e Lilly Wachowski",
        "James Cameron",
        "Christopher Nolan",
        "Quentin Tarantino",
        "Roberto Benigni",
        "Christopher Nolan"
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il regista: ");
            string regista = Console.ReadLine();

            int AnnoInizio = LeggiNumero("Anno pubblicazione iniziale: ");

            int AnnoFine = LeggiNumero("Anno pubblicazione finale: ");

            Cerca(titoli, anniPubblicazione, registi, regista, AnnoInizio, AnnoFine);

        }

        private static void Cerca(string[] titoli, int[] anniPubblicazione, string[] registi, string regista, int annoInizio, int annoFine)
        {
            bool trovato = false;

            for (int i = 0; i < titoli.Length; i++)
            {
                if (anniPubblicazione[i] >= annoInizio && anniPubblicazione[i] <= annoFine)
                {
                    Console.WriteLine($"Film trovati del regista{regista} tra gli anni {annoInizio} e {annoFine}: {titoli[i]} {anniPubblicazione[i]}");
                    trovato = true;
                }
                if (!trovato)
                {
                    Console.WriteLine("Nessun DVD trovato.");
                }
            }
        }
    }

}
