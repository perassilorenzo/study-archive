using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0119_es6pag115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 6 pagina 115
            // dati i vettori come nell'esercizio precedente, visualizzare per ogni squadra il numero di giocatori.
            // ordinare i risultati ricavati in base al numero di giocatori in ordine crescente

            string[] cognomi = { "Rossi", "Bianchi", "Verdi", "Esposito", "Ferrari", "Romano", "Gallo", "Conti", "DeLuca", "Mancini" };
            string[] nomi = { "Marco", "Luca", "Andrea", "Giuseppe", "Paolo", "Antonio", "Francesco", "Stefano", "Matteo", "Davide" };
            string[] squadre = { "Juventus", "Milan", "Inter", "Napoli", "Roma", "Lazio", "Atalanta", "Fiorentina", "Torino", "Bologna" };

            Stampa(cognomi, nomi, squadre);
        }

        private static void Stampa(string[] cognomi, string[] nomi, string[] squadre)
        {
            string[] nomiSquadre = new string[squadre.Length];
            int[] conteggi = new int[squadre.Length];
            int nSquadre = 0;

            for (int i = 0; i < squadre.Length; i++)
            {
                int pos = -1;

                for (int j = 0; j < nSquadre; j++)
                {
                    if (nomiSquadre[j] == squadre[i])
                    {
                        pos = j;
                        break;
                    }
                }

                if (pos == -1)
                {
                    nomiSquadre[nSquadre] = squadre[i];
                    conteggi[nSquadre] = 1;
                    nSquadre++;
                }
                else
                {
                    conteggi[pos]++;
                }
            }

            for (int i = 0; i < nSquadre - 1; i++)
            {
                for (int j = 0; j < nSquadre - 1 - i; j++)
                {
                    if (conteggi[j] > conteggi[j + 1])
                    {
                        int temp = conteggi[j];
                        conteggi[j] = conteggi[j + 1];
                        conteggi[j + 1] = temp;

                        string tempS = nomiSquadre[j];
                        nomiSquadre[j] = nomiSquadre[j + 1];
                        nomiSquadre[j + 1] = tempS;
                    }
                }
            }

            for (int i = 0; i < nSquadre; i++)
            {
                Console.WriteLine($"{nomiSquadre[i]} - {conteggi[i]}");
            }
        }
    }
}
