using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0825_modulo6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Studente> matricole = new Dictionary<int, Studente>();

            matricole.Add(1, new Studente("Lorenzo", "Perassi", 17));
            matricole.Add(2, new Studente("Marco", "Rossi", 16));
            matricole.Add(3, new Studente("Giulia", "Bianchi", 17));
            matricole.Add(4, new Studente("Matteo", "Ferrari", 18));

            if (!matricole.TryGetValue(1, out  Studente studente))
            {
                Console.WriteLine("Valore non valido");
                return;
            }
            Console.WriteLine(studente);

            matricole.Remove(2);
        }
    }
}
