using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1101_modulo7_2
{
    public class Contatore
    {
        private int valore;

        private Contatore()
        {
            valore = 0;
        }

        public static Contatore CreaContatore()
        {
            return new Contatore();
        }

        public void Incrementa()
        {
            valore++;
        }

        public void Reset()
        {
            valore = 0;
        }

        public int Valore
        {
            get { return valore; }
        }

        /*
        +----------------------------------+
        |             Contatore            |
        +----------------------------------+
        | - valore: int                    |
        +----------------------------------+
        | - Contatore()                    |
        | + CreaContatore(): Contatore     |
        | + Incrementa(): void             |
        | + Reset(): void                  |
        | + Valore: int { get }            |
        +----------------------------------+
        */

    }
}
