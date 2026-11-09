using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1104_gestione_libreria
{
    public class Rivista : Pubblicazione
    {
        public int NumeroEdizione { get; set; }

        public Rivista(string titolo, string autore, double prezzo, int numeroEdizione) : base(titolo, autore, prezzo)
        {
            this.NumeroEdizione = numeroEdizione;
        }

        public override string VisualizzaInfo()
        {
            return base.VisualizzaInfo() + "\nNumero edizione: " + NumeroEdizione;
        }
    }
}