using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0825_modulo5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Studente> studenti = new Dictionary<int, Studente>();
            
            studenti.Add(1, new Studente("Mario", "Rossi", 17));
            studenti.Add(2, new Studente("Tommaso", "Astro", 16));
            studenti.Add(3, new Studente("Argo", "Albatros", 21));

            if (studenti.TryGetValue(1, out Studente s))
            {
                Console.WriteLine($"Studente trovato: {s.Nome} {s.Cognome} con {s.Eta} anni");
            }

            studenti.Remove(2);
        }
    }
}
