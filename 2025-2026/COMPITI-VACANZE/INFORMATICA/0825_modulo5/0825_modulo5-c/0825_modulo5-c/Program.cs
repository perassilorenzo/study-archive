using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0825_modulo5_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Studente, int> Voto = new Dictionary<Studente, int>();

            Voto.Add(new Studente("Lorenzo", "Perassi", 17, 1), 10); Voto.Add(new Studente("Marco", "Rossi", 16, 2), 8);
            Voto.Add(new Studente("Giulia", "Bianchi", 17, 3), 9);
            Voto.Add(new Studente("Matteo", "Ferrari", 18, 4), 7);
            Voto.Add(new Studente("Alice", "Romano", 16, 5), 8);
            Voto.Add(new Studente("Davide", "Esposito", 17, 6), 6);
            Voto.Add(new Studente("Sofia", "Colombo", 18, 7), 10);
            Voto.Add(new Studente("Luca", "Greco", 17, 8), 9);
            Voto.Add(new Studente("Chiara", "Marino", 16, 9), 7);

            AddMark(Voto);
            AvgMark(Voto);
            MaxMark(Voto);
        }

        private static Studente MaxMark(Dictionary<Studente, int> voto)
        {
            int max = -1;
            Studente maxStudent = null;
            foreach(var el in voto)
            {
                if (el.Value > max)
                {
                    max = el.Value;
                    maxStudent = el.Key;
                } 
            }

            return maxStudent;
        }

        private static double AvgMark(Dictionary<Studente, int> voto)
        {
            double sum = 0;
            int count = 0;
            foreach (int s in voto.Values)
            {
                sum += s;
                count++;
            }

            return sum / count;

        }

        private static void AddMark(Dictionary<Studente, int> voto)
        {
            int ID;
            Console.WriteLine("Inserisci l'ID dello studente");
            if (!int.TryParse(Console.ReadLine(), out ID))
            {
                Console.WriteLine("Valore non valido");
                return;
            }

            int Voto;
            Console.WriteLine("Inserisci il voto da modificare");
            if (!int.TryParse(Console.ReadLine(),out Voto))
            {
                Console.WriteLine("Valore non valido");
                return;
            }

            foreach(Studente studente in voto.Keys)
            {
                if (studente.ID == ID) voto[studente] = Voto;
            }
        }
    }
}
