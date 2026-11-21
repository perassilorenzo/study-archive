using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1116_oop_regex_esercizio1
{
    internal class Rivista : Materiale
    {
        public int NumeroEdizione { get; set; }

        public Rivista(string titolo, string codice, int numeroEdizione) : base(titolo, codice)
        {
            NumeroEdizione = numeroEdizione;
        }

        public override string Descrivi()
        {
            return base.Descrivi() + $", Numero edizione: {NumeroEdizione}";
        }
    }

}
