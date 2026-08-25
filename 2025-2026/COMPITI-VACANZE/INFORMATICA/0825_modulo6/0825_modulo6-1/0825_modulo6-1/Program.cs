using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0825_modulo6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studente> studenti = new List<Studente>();

            studenti.Add(new Studente("Lorenzo", "Perassi", 17)); studenti.Add(new Studente("Marco", "Rossi", 16));
            studenti.Add(new Studente("Giulia", "Bianchi", 17));
            studenti.Add(new Studente("Matteo", "Ferrari", 18));
            studenti.Add(new Studente("Sofia", "Colombo", 16));
            studenti.Add(new Studente("Luca", "Greco", 17));

            studenti.RemoveAt(1);
            Console.WriteLine(studenti.Find(s => s.Nome == "Lorenzo").Cognome);
        }
    }
}
