using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1116_oop_regex_esercizio1
{
    public class Materiale
    {
        private string titolo;
        private string codice;

        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }

        public string Codice
        {
            get { return codice; }
            private set { codice = value; }
        }

        public Materiale(string titolo, string codice)
        {
            Titolo = titolo;
            Codice = codice;
        }

        public virtual string Descrivi()
        {
            return $"Titolo: {Titolo}, Codice: {Codice}";
        }
    }
}
