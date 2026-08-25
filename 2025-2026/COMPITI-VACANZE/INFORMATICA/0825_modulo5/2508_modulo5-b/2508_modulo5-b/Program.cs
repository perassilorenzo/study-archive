using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0825_modulo5_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lista studenti con tutti gli studenti inseriti al suo interno con le informazioni
            List<Studente> studenti = new List<Studente>();

            studenti.Add(new Studente("Lorenzo", "Perassi", 17));
            studenti.Add(new Studente("Marco", "Rossi", 16));
            studenti.Add(new Studente("Giulia", "Bianchi", 17));
            studenti.Add(new Studente("Matteo", "Ferrari", 18));
            studenti.Add(new Studente("Alice", "Romano", 16));
            studenti.Add(new Studente("Davide", "Esposito", 17));
            studenti.Add(new Studente("Sofia", "Colombo", 18));
            studenti.Add(new Studente("Luca", "Greco", 17));
            studenti.Add(new Studente("Chiara", "Marino", 16));

            // ordina la lista esistente per cognomi a-z
            studenti.Sort((a, b) => a.Cognome.CompareTo(b.Cognome));

            // stampa la suddetta lista ordinata
            foreach(Studente student in studenti)
            {
                Console.WriteLine($"{student.Nome} {student.Cognome} con {student.Eta} anni");
            }

            // stampa studente per studente tutti quelli che hanno Eta > 16
            foreach (Studente s in studenti.FindAll(s => s.Eta > 16))
            {
                Console.WriteLine($"{s.Nome} {s.Cognome} con {s.Eta} anni")
            }

            // dizionario con la matricola associata allo studente
            Dictionary<int, Studente> matricole = new Dictionary<int, Studente>();

            matricole[0] = studenti[0];
            matricole[1] = studenti[1];
            matricole[2] = studenti[2];
            matricole[3] = studenti[3];
            matricole[4] = studenti[4];
            matricole[5] = studenti[5];
            matricole[6] = studenti[6];
            matricole[7] = studenti[7];
            matricole[8] = studenti[8];

            // queue per gestire lista d'attesa, primo dentro primo fuori
            Queue<string> Attese = new Queue<string>();

            Attese.Enqueue(studenti[3].Cognome);
            Attese.Enqueue(studenti[7].Cognome);
            Attese.Enqueue(studenti[8].Cognome);

            string ricevuto = Attese.Dequeue();

            // stack per gestire le operazioni passate ultimo dentro primo fuori
            Stack<string> Operazioni = new Stack<string>();

            Operazioni.Push("Modifica 1");
            Operazioni.Push("Modifica 2");
            Operazioni.Push("Modifica 3");

            Operazioni.Pop();
        }


    }
}
