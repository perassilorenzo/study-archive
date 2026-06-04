using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo1c
{
    // Classe per testare la classe Persona
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Mario", "Rossi", 25);
            persona1.ToString();

            // Test: tentativo di impostare un'età negativa
            persona1.Eta = -5;  // Verrà visualizzato un messaggio di errore
            Console.WriteLine($"Età corrente: {persona1.Eta}");

            Console.WriteLine("Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}

// miglioramenti e refactoring:
//- utilizzo delle eccezioni al posto dei Console.WriteLine()
//- aggiunta del metodo ToString();

//+------------------------------+
//|          Persona             |
//+------------------------------+
//| - MAX_LENGTH: const int      |
//| - nome: string               |
//| - cognome: string            |
//| - eta: int                   |
//+------------------------------+
//| +Persona(nome, cognome, eta) |
//| +Nome: string {get; set;}    |
//| +Cognome: string {get; set;} |
//| +Eta: int {get; set;}        |
//| +ToString: ovveride string   |
//+------------------------------+