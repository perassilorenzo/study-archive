using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1116_oop_regex_esercizio1
{
    internal class DVD : Materiale
    {
        public int DurataMinuti { get; set; }

        public DVD(string titolo, string codice, int durataMinuti)
            : base(titolo, codice)
        {
            DurataMinuti = durataMinuti;
        }

        public override string Descrivi()
        {
            return base.Descrivi() + $", Durata: {DurataMinuti} minuti";
        }
    }
}
