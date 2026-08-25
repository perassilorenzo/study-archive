using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0824_modulo3_a
{
    public class Contatore
    {
        public static int TotaleIstanza { get; private set; }
        public int Conteggio;

        public Contatore()
        {
            Conteggio = 0;
            TotaleIstanza++;
        }
        
        public static void Reset()
        {
            TotaleIstanza = 0;
        }
    }
}

// diagramma UML
//
//+------------------------------+
//| Contatore                    |
//+------------------------------+
//| + TotaleIstanza: int {static}|
//| + Conteggio: int             |
//+------------------------------+
//| + Contatore()                |
//| + Reset(): void {static}     |
//+------------------------------+
//