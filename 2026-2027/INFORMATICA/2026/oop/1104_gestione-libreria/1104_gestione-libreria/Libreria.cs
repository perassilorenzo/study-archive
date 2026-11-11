using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1104_gestione_libreria
{
    public class Libreria
    {
        public List<Pubblicazione> list = new List<Pubblicazione>();

        public void AggiungiPubblicazione(Pubblicazione p)
        {
            list.Add(p);
        }

        public string VisualizzaCatalogo()
        {
            string risultato = "";

            foreach (Pubblicazione p in list)
                risultato += p.Titolo + " - " + p.Autore + " - " + p.Prezzo + " euro\n";

            return risultato;
        }

        public Pubblicazione CercaPerTitolo(string titolo)
        {
            foreach (Pubblicazione p in list)
                if (p.Titolo.ToLower() == titolo.ToLower())
                    return p;

            return null;
        }

        public double CalcolaPrezzoMedio()
        {
            if (list.Count == 0)
                return 0;

            double somma = 0;

            foreach (Pubblicazione p in list)
                somma += p.Prezzo;

            return somma / list.Count;
        }
    }
}