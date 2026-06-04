using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260528_modulo11
{
    public class Persona
    {
        private string nome;
        private string cognome;
        private int eta;

        public Persona(string nome, string cognome, int eta)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Eta = eta;
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
    }
}