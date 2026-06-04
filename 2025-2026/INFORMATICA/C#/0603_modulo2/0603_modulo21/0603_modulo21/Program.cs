using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo21
{
    // Classe per testare la classe Persona
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Mario", "Rossi", 25);
            Console.WriteLine($"{persona1.Nome} {persona1.Cognome}, Età: {persona1.Eta}");

            // Test: tentativo di impostare un'età negativa
            persona1.Eta = -5;  // Verrà visualizzato un messaggio di errore
            Console.WriteLine($"Età corrente: {persona1.Eta}");

            persona1.Cognome = "";
            Console.WriteLine($"Cognome corrente: {persona1.Cognome}");

            Console.WriteLine("Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}