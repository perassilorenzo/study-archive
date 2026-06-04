using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0528_modulo13
{
    public class Persona
    {
        private string nome;
        private string cognome;
        private int eta;

        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
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
                if (value > 0)
                {
                    eta = value;
                }
                else
                {
                    Console.WriteLine("L'età deve essere maggiore di 0");
                }
            }
        }
    }
}
