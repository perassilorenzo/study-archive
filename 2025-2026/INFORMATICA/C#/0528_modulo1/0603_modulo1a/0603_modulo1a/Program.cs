using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo1a
{
    public class Persona
    {
        public string nome;
        public string cognome;
        public int eta;
        public string indirizzo;
        
        public Persona(string nome, string cognome, int eta, string indirizzo)
        {
            this.Nome = nome; 
            this.Cognome = cognome;
            this.Eta = eta;
            this.Indirizzo = indirizzo;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public int Eta
        {
            get { return eta; }
            set
            {
                if (value > 0) eta = value;
                else Console.WriteLine("L'età deve essere maggiore di 0");
            }
        }

        public string Indirizzo
        {
            get { return indirizzo; }
            set {  indirizzo = value; }
        }
    }
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