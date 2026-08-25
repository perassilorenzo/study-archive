using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0825_modulo6_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studente> studenti = new List<Studente>();
            Dictionary<int, Studente> matricole = new Dictionary<int, Studente>();

            switch (Menu())
            {
                case 1:
                    AddStudent(studenti, matricole);
                    break;

                case 2:
                    RemoveStudent(studenti, matricole);
                    break;

                case 3:
                    FindStudent(studenti, matricole);
                    break;

                case 4:
                    ModifyRecord(studenti, matricole);
                    break;

                default:
                    Console.WriteLine("Valore non valido");
                    break;
            }


        }

        private static void ModifyRecord(List<Studente> studenti, Dictionary<int, Studente> matricole)
        {
            Console.WriteLine("Inserisci l'ID da sostituire");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (var m in matricole)
            {
                if (m.Key == id)
                {
                    Console.WriteLine("Inserisci il nuovo nome");
                    m.Value.Nome = Console.ReadLine();

                    Console.WriteLine("Inserisci il nuovo cognome");
                    m.Value.Cognome = Console.ReadLine();

                    Console.WriteLine("Inserisci la nuova età");
                    m.Value.Eta = Convert.ToInt32(Console.ReadLine());
                }
            }

            
        }

        private static void FindStudent(List<Studente> studenti, Dictionary<int, Studente> matricole)
        {
            Console.WriteLine("Inserisci l'ID dello studente da cercare");
            int id = Convert.ToInt32(Console.ReadLine());

            if (matricole.TryGetValue(id, out Studente studente))
            {
                Console.WriteLine($"Lo studente {studente.Nome} è stato trovato");
            }
            else
            {
                Console.WriteLine("Non è stato trovato");
            }
        }

        private static void RemoveStudent(List<Studente> studenti, Dictionary<int, Studente> matricole)
        {
            Console.WriteLine("Inserisci l'ID da eliminare");
            int id = Convert.ToInt32(Console.ReadLine());

            if (matricole.TryGetValue(id, out Studente studente))
            {
                matricole.Remove(id);
                studenti.Remove(studente);

                Console.WriteLine("Studente eliminato");
            }
            else
            {
                Console.WriteLine("ID non trovato");
            }
        }

        private static void AddStudent(List<Studente> studenti, Dictionary<int, Studente> matricole)
        {
            Console.WriteLine("Inserisci il nuovo nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il nuovo cognome");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci l'età");
            int eta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci l'ID");
            int id = Convert.ToInt32(Console.ReadLine());

            Studente nuovo = new Studente(nome, cognome, eta);

            studenti.Add(nuovo);
            matricole.Add(id, nuovo);

        }

        private static int Menu()
        {
            int choice = 0;
            
            Console.WriteLine("Fai una scelta:");
            Console.WriteLine("1 -> Aggiunge un nuovo studente");
            Console.WriteLine("2 -> Rimuove uno studente");
            Console.WriteLine("3 -> Cerca uno studente");
            Console.WriteLine("4 -> Modifica un record");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Valore non valido");
            }

            return choice;
        }
    }
}
