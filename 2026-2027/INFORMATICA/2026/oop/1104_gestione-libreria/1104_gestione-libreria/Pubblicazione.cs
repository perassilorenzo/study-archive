using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1104_gestione_libreria
{
    public class Pubblicazione
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public double Prezzo { get; set; }

        public Pubblicazione(string titolo, string autore, double prezzo)
        {
            this.Titolo = titolo;
            this.Autore = autore;
            this.Prezzo = prezzo;
        }

        public virtual string VisualizzaInfo()
        {
            return "Titolo: " + Titolo + "\nAutore: " + Autore + "\nPrezzo: " + Prezzo + " euro";
        }
    }
}