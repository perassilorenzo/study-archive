using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260528_modulo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Sara", "Martinelli", 67);
            Console.WriteLine($"{persona1.Nome} {persona1.Cognome}, Età: {persona1.Eta}");

            Persona persona2 = new Persona("Pietrho", "Isaiah", 76);
            Console.WriteLine($"{persona2.Nome} {persona2.Cognome}, Età: {persona2.Eta}");

            Console.ReadKey();
        }
    }
}
