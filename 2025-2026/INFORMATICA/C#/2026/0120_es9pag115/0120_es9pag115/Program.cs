using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0120_es9pag115
{
    internal class Program
    {
        static string[] Studenti = { "Alessio", "Martina", "Luca", "Giulia", "Davide", "Chiara", "Matteo", "Sofia", "Andrea", "Elena", "Federico", "Sara", "Marco", "Valentina", "Tommaso", "Alice", "Pietro", "Francesca", "Nicolò", "Beatrice" };
        static string[] Città = { "Torino", "Milano", "Roma", "Napoli", "Firenze", "Bologna", "Genova", "Venezia", "Palermo", "Cagliari", "Verona", "Padova", "Trieste", "Bari", "Perugia", "Parma", "Modena", "Rimini", "Pisa", "Lecce" };
    
        static void Main(string[] args)
        {
            // esercizio 9 pagina 115
            // sono dati due vettori parealleli chiamati Studenti e Città entrambi lunghi n e contenenti un elenco di nominativi di studenti e la loro rispettiva città di residenza.
            // contare il numero di studdenti che risedono in una città ricevuta in ingresso , supponendo che il vettore Città sia rodinato in senso crescente

            bool found = false, superato = false;
            int i = 0, count = 0;

            Console.WriteLine("Inserisci il nome della città da cercare");
            string città = Console.ReadLine();

            while(!superato && i < Studenti.Length)
            {
                if (Città[i] == città)
                {
                    found = true;
                    count++;
                    i++;
                }
                else
                {
                    if (Città[i].CompareTo(città) > 0)
                    {
                        found = true;
                    }
                    else i++;
                }
            }

            Console.WriteLine($"Il numero degli studenti residenti a {città} sono {count}");
            Console.ReadKey();
        }
    }
}
