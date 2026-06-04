using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo1a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Mario", "Rossi", 25, "Corso Italia 45");
            Console.WriteLine($"{persona.Nome} {persona.Cognome}, {persona.Eta}, {persona.Indirizzo}");
        }
    }
}

//  ============ UML ============

//+------------------------------+
//|          Persona             |
//+------------------------------+
//| - nome: string               |
//| - cognome: string            |
//| - eta: int                   |
//| - indirizzo: string          |
//+------------------------------+
//| +Persona(nome, cognome, eta) |
//| +Nome: string {get; set;}    |
//| +Cognome: string {get; set;} |
//| +Eta: int {get; set;}        |
//| +Indirizzo: string{get; set} |
//+------------------------------+