using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0824_modulo4_2
{
    internal class Configurazione
    {
        private static Configurazione _instance;
        private Configurazione()
        {
            Ambiente = "Sviluppo";
            Versione = "1.0";
        }
        
        public static Configurazione Instance
        {
            get
            {
                if (_instance == null) _instance = new Configurazione();
                return _instance;
            }
        }
        
        public string Ambiente { get; set; }
        public string Versione { get; set; }
    }
}

//+-------------------------------------+
//| Configurazione                      |
//+-------------------------------------+
//| - _instance: Configurazione {static}|
//| + Instance: Configurazione {static} |
//| + Ambiete: string                   |
//| + Versione: string                  |
//+-------------------------------------+
//| - Configurazione                    |  
//+-------------------------------------+
//