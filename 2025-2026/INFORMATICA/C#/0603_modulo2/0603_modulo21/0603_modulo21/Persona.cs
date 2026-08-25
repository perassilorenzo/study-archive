using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo21
{
    public class Persona
    {
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
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Il nome non può essere nullo");
                nome = value;
            }
        }

        // Proprietà per 'Cognome'
        public string Cognome
        {
            get { return cognome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Il cognome non può essere nullo");
                cognome = value;
            }
        }

        // Proprietà per 'Eta' con validazione
        public int Eta
        {
            get { return eta; }
            set
            {
                if (value > 0)
                    eta = value;
                else
                    Console.WriteLine("Errore: l'età deve essere maggiore di 0.");
            }
        }
    }
}
