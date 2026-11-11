using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1104_gestione_libreria
{
    public class Libro : Pubblicazione
    {
        public int NumeroPagine { get; set; }

        public Libro(string titolo, string autore, double prezzo, int numeroPagine) : base(titolo, autore, prezzo)
        {
            this.NumeroPagine = numeroPagine;
        }

        public override string VisualizzaInfo()
        {
            return base.VisualizzaInfo() + "\nNumero pagine: " + NumeroPagine;
        }
    }
}