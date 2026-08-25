using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0825_modulo6_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studente> studenti = new List<Studente>();

            studenti.Add(new Studente("Lorenzo", "Perassi", 17)); studenti.Add(new Studente("Marco", "Rossi", 16));
            studenti.Add(new Studente("Giulia", "Bianchi", 17));
            studenti.Add(new Studente("Matteo", "Ferrari", 18));
            studenti.Add(new Studente("Sofia", "Romano", 16));
            studenti.Add(new Studente("Luca", "Esposito", 17));
            studenti.Add(new Studente("Alice", "Colombo", 18));
            studenti.Add(new Studente("Davide", "Greco", 17));
            studenti.Add(new Studente("Chiara", "Marino", 16));

            studenti.Sort((a, b) => a.Cognome.CompareTo(b.Cognome));

            Console.WriteLine("Inserisci il filtro età");
            int filter = Convert.ToInt32(Console.ReadLine());
            
            foreach (Studente s in studenti.FindAll(st => st.Eta > filter))
            {
                Console.WriteLine($"{s.Nome} {s.Cognome} con {s.Eta} anni");
            }
        
        }
    }
}
