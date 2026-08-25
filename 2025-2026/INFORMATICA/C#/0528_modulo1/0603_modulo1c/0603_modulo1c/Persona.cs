using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo1c
{
    public class Persona
    {
        private const int MAX_LENGHT = 100;
        // Attributi privati
        private string nome;
        private string cognome;
        private int eta;

        // Costruttore
        public Persona(string nome, string cognome, int eta)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Eta = eta; // Utilizza la proprietà per applicare il controllo
        }

        // Proprietà per 'Nome'
        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 0 && value.Length < MAX_LENGHT) nome = value;
                else throw new ArgumentException($"Il nome non può superare {MAX_LENGHT} char o non può avere char negativi");
            }
        }

        // Proprietà per 'Cognome'
        public string Cognome
        {
            get { return cognome; }
            set
            {
                if (value.Length > 0 && value.Length < MAX_LENGHT) cognome = value;
                else throw new ArgumentException($"Il cognome non può superare {MAX_LENGHT} char o non può avere char negativi");
            }
        }

        // Proprietà per 'Eta' con validazione
        public int Eta
        {
            get { return eta; }
            set
            {
                if (value > 0) eta = value;
                else throw new ArgumentException("L'età deve essere positiva");
            }
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome}, Età: {Eta}";
        }
    }
}
