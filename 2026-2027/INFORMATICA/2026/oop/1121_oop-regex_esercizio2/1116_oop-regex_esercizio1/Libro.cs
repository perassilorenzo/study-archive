using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1116_oop_regex_esercizio1
{
    public class Libro : Materiale
    {
        public string Autore { get; set; }

        public Libro(string titolo, string codice, string autore) : base(titolo, codice)
        {
            Autore = autore;
        }

        public override string Descrivi()
        {
            return base.Descrivi() + $", Autore: {Autore}";
        }
    }

}
