using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0825_modulo6_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dictionary id dello studente -> voto
            Dictionary<int, int> studente = new Dictionary<int, int>();

            studente.Add(1, 8);
            studente.Add(2, 7);
            studente.Add(3, 9);
            studente.Add(4, 6);
            studente.Add(5, 10);
            studente.Add(6, 8);
            studente.Add(7, 7);
            studente.Add(8, 9);

            // aggiorna il voto dello studente con id 4
            UpdateMark(studente, 4, 9);

            // calcola e visualizza la media
            double media = AvgMark(studente);
            Console.WriteLine("La media dei voti è: " + media);

            // trova e visualizza lo studente con il voto massimo
            int idMax = MaxMark(studente);
            Console.WriteLine($"Lo studente con il voto massimo ha ID: {idMax}");
            Console.WriteLine($"Il suo voto è: {studente[idMax]}");
        }

        // funzione per aggiornare il voto di uno studente
        static void UpdateMark(Dictionary<int, int> studente, int id, int nuovoVoto)
        {
            if (studente.ContainsKey(id))
            {
                studente[id] = nuovoVoto;
            }
            else
            {
                Console.WriteLine("Studente non trovato.");
            }
        }

        // funzione per calcolare la media di tutti i voti
        static double AvgMark(Dictionary<int, int> studente)
        {
            int somma = 0;
            foreach (int voto in studente.Values)
            {
                somma += voto;
            }

            return (double)somma / studente.Count;
        }

        // funzione che restituisce l'ID dello studente con il voto più alto
        static int MaxMark(Dictionary<int, int> studente)
        {
            int max = -1;
            int idMax = -1;

            foreach (var el in studente)
            {
                if (el.Value > max)
                {
                    max = el.Value;
                    idMax = el.Key;
                }
            }

            return idMax;
        }
    }
}