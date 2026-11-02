using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1101_modulo7_a
{
    public class Studente
    {

        public int Matricola { get; private set; }
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public int Eta { get; private set; }

        public Studente(int matricola, string nome, string cognome, int eta)
        {
            if (matricola <= 0 || eta <= 0 || nome == "" || cognome == "")
                throw new Exception("Dati non validi.");

            Matricola = matricola;
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public void ModificaDati(string nome, string cognome, int eta)
        {
            if (nome == "" || cognome == "" || eta <= 0)
                throw new Exception("Dati non validi.");

            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public override string ToString()
        {
            return Matricola + " - " + Nome + " " + Cognome + " - " + Eta + " anni";
        }
        
        // UML:
        // -----------------------------
        // |         Studente          |
        // -----------------------------
        // | - matricola: int          |
        // | - nome: string            |
        // | - cognome: string         |
        // | - eta: int                |
        // -----------------------------
        // | + Studente(...)           |
        // | + ModificaDati(...): void |
        // | + ToString(): string      |
        // -----------------------------
    }
}
