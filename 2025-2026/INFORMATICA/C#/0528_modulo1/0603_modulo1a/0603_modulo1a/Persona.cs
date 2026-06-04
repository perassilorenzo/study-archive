using System;
using System.Collections.Generic;
using System.Linq;
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
            set { indirizzo = value; }
        }
    }
}
