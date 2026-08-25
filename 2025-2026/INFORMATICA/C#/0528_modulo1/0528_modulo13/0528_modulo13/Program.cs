using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0528_modulo13
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Matteo", "Montepeloso", 2);

            Console.WriteLine($"{persona1.Nome} {persona1.Cognome}, Età: {persona1.Eta}");

            persona1.Nome = "Paolo";
            persona1.Eta = 67;

            Console.WriteLine($"{persona1.Nome} {persona1.Cognome}, Età: {persona1.Eta}");

            persona1.Eta = -5;

            Console.WriteLine($"{persona1.Nome} {persona1.Cognome}, Età: {persona1.Eta}");

            Console.ReadKey();
        }
    }
}