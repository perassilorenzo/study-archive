using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

// refactoring
// - gestione di spazi vuoti e null tramite string.IsNullOrWhiteSpace()
// - utilizzo delle eccezioni per migliorare la leggibilità al posto dei Console.WriteLine();
// - utilizzo di un valore massimo costate di char per le stringhe e ovveride string

//+----------------------+
//|       Persona        |
//+----------------------+
//| - nome : string      |
//| - cognome : string   |
//| - eta : int          |
//| - MAX_LENGTH : int   |
//+----------------------+
//| + Nome : string      |
//| + Cognome : string   |
//| + Eta : int          |
//| + ToString() : string|
//+----------------------+