using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0824_modulo3_1
{
    public class Contatore
    {
        public static int TotaleIstanza = 0;
        public int Conteggio;

        public Contatore()
        {
            Conteggio = 0;
            TotaleIstanza++;
        }
    }
}
