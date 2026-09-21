using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0921_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;

            Persona p1;
            p1 = new Persona("Aldo", "Rossi", 32);
            Persona p2 = new Persona("Marco", "Bianchi", -38);

            Console.WriteLine($"Persona 1:\n{p1.Nome} {p1.Cognome} di {p1.Eta}");
            Console.WriteLine($"Persona 2:\n{p2.Nome} {p2.Cognome} di {p2.Eta}");
        }
    }
}
