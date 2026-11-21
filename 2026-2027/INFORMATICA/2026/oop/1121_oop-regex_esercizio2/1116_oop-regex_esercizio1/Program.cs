using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1116_oop_regex_esercizio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Materiale> materiali = new List<Materiale>();

            materiali.Add(new Libro("1984", "LB123", "Orwell, George"));
            materiali.Add(new Libro("Il Signore degli Anelli", "LB124", "Tolkien, John"));

            materiali.Add(new Rivista("Focus", "RV001", 12));
            materiali.Add(new Rivista("National Geographic", "RV002", 25));

            materiali.Add(new DVD("Interstellar", "DV001", 169));

            Console.WriteLine("MATERIALI BIBLIOTECA:");

            foreach (Materiale m in materiali)
                Console.WriteLine(m.Descrivi());

            Console.WriteLine("\nLISTA D'ATTESA:");

            Queue<string> attesa = new Queue<string>();

            attesa.Enqueue("Mario");
            attesa.Enqueue("Luca");

            Console.WriteLine("Primo in attesa: " + attesa.Peek());

            attesa.Dequeue();

            Console.WriteLine("\nRICERCA PER CODICE:");

            Dictionary<string, Materiale> dizionario = new Dictionary<string, Materiale>();

            foreach (Materiale m in materiali)
                dizionario.Add(m.Codice, m);

            string codiceRicerca = "LB123";

            Materiale trovato;

            if (dizionario.TryGetValue(codiceRicerca, out trovato))
                Console.WriteLine(trovato.Descrivi());
            
            else
                Console.WriteLine("Materiale non trovato");

            Console.WriteLine("\nVALIDAZIONE CODICE:");

            string codice = "LB123";

            if (Regex.IsMatch(codice, @"^[A-Z]{2}\d{3,5}$"))
                Console.WriteLine("Codice valido");
            
            else
                Console.WriteLine("Codice non valido");

            Console.WriteLine("\nRICERCA PER TITOLO:");

            string parola = "focus";

            foreach (Materiale m in materiali)
                if (m.Titolo.IndexOf(parola, StringComparison.OrdinalIgnoreCase) >= 0)
                    Console.WriteLine(m.Descrivi());

            Console.WriteLine("\nVALIDAZIONE AUTORE:");

            string autore = "Rossi, Mario";

            if (Regex.IsMatch(autore, @"^[A-Z][a-z]+, [A-Z][a-z]+$"))
                Console.WriteLine("Autore valido");
            
            else
                Console.WriteLine("Autore non valido");

            /* ========== esercizio 2 ========== */

            Stack<string> cronologia = new Stack<string>();

            cronologia.Push("Prestito effettuato");
            cronologia.Push("Materiale restituito");
            cronologia.Push("Nuovo materiale aggiunto");

            Console.WriteLine("\nULTIMA AZIONE:");
            Console.WriteLine(cronologia.Peek());

            Console.WriteLine("\nANNULLATA:");

            string ultimaAzione = cronologia.Pop();
            Console.WriteLine("Azione annullata: " + ultimaAzione);

            Console.WriteLine("\nCRONOLOGIA AGGIORNATA:");

            foreach (string azione in cronologia)
                Console.WriteLine(azione);
        }
    }
}