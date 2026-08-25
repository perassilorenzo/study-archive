using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0824_modulo3_2
{
    public class Configurazione
    {
        public static string Impostazioni { get; private set; }

        static Configurazione()
        {
            Impostazioni = "Configurazione Iniziale";
        }
    }
}
