using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0825_modulo5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studente> studenti = new List<Studente>();

            studenti.Add(new Studente("Stefano", "Lemma", 15));
            studenti.Add(new Studente("Stefano", "Lemma", 15));
            studenti.Add(new Studente("Stefano", "Lemma", 15));
            studenti.Add(new Studente("Luca", "Lemma", 15));
            studenti.Add(new Studente("Stefano", "Lemma", 15));

            studenti.RemoveAt(2);
            Studente trovato = studenti.Find(s => s.Nome == "Luca");

            if (trovato != null)
            {
                Console.WriteLine($"Studente trovato: {trovato.Nome} {trovato.Cognome} con {trovato.Eta} anni");
            }
            else Console.WriteLine("Studente non trovato");
        }
    }
}
