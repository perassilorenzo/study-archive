using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0119_es5pag115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 5 pagina 115
            // le informazioni riguardanti i giocatori di calcio sono caricati in tre vettori chiamati Cognomi, Nomi, Squadre lunghi n.
            // copiare i nominativi dei giocatori che militano in una squadra di calcio ricevuta in ingresso in altri due vettori d'appoggio
            // e ordinare quest'ultimi applicando l'algoritmo del bubble sort

            string[] cognomi = { "Rossi", "Bianchi", "Verdi", "Esposito", "Ferrari", "Romano", "Gallo", "Conti", "DeLuca", "Mancini" };
            string[] nomi = { "Marco", "Luca", "Andrea", "Giuseppe", "Paolo", "Antonio", "Francesco", "Stefano", "Matteo", "Davide" };
            string[] squadre = { "Juventus", "Milan", "Inter", "Napoli", "Roma", "Lazio", "Atalanta", "Fiorentina", "Torino", "Bologna" };

            Console.WriteLine("Inserisci la squadra:");
            string squadra = Console.ReadLine();

            Copia(cognomi, nomi, squadre, squadra, out string[] cognomi2, out string[] nomi2);

            BubbleSort(cognomi2, nomi2);

            for (int i = 0; i < cognomi2.Length; i++)
            {
                Console.WriteLine($"{cognomi2[i]} {nomi2[i]}");
            }
        }

        private static void BubbleSort(string[] cognomi2, string[] nomi2)
        {
            for (int i = 0; i < cognomi2.Length - 1; i++)
            {
                for (int j = 0; j < cognomi2.Length - 1 - i; j++)
                {
                    if (string.Compare(cognomi2[j], cognomi2[j + 1]) > 0)
                    {
                        string temp = cognomi2[j];
                        cognomi2[j] = cognomi2[j + 1];
                        cognomi2[j + 1] = temp;

                        temp = nomi2[j];
                        nomi2[j] = nomi2[j + 1];
                        nomi2[j + 1] = temp;
                    }
                }
            }
        }

        private static void Copia(string[] cognomi, string[] nomi, string[] squadre, string squadra, out string[] cognomi2, out string[] nomi2)
        {
            int count = 0;
            for (int i = 0; i < squadre.Length; i++)
            {
                if (squadra == squadre[i]) count++;
            }

            cognomi2 = new string[count];
            nomi2 = new string[count];

            int k = 0;
            for (int i = 0; i < squadre.Length; i++)
            {
                if (squadra == squadre[i])
                {
                    cognomi2[k] = cognomi[i];
                    nomi2[k] = nomi[i];
                    k++;    
                }
            }
        }
    }
}
