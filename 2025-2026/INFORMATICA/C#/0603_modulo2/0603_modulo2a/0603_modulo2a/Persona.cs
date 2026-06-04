using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo2a
{
    public class Persona
    {
        private const int MAX_LENGTH = 100;

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
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Il nome non può essere vuoto.");

                if (value.Length > MAX_LENGTH)
                    throw new ArgumentException($"Il nome non può superare {MAX_LENGTH} caratteri.");

                nome = value;
            }
        }

        public string Cognome
        {
            get { return cognome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Il cognome non può essere vuoto.");

                if (value.Length > MAX_LENGTH)
                    throw new ArgumentException($"Il cognome non può superare {MAX_LENGTH} caratteri.");

                cognome = value;
            }
        }

        public int Eta
        {
            get { return eta; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("L'età deve essere maggiore di 0.");

                eta = value;
            }
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome}, Età: {Eta}";
        }
    }
}
