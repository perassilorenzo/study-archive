using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1009_esercizio01
{
    public class clsVeicoli
    {
        private string pMarca;
        private string pColore;
        private string pModello;
        private uint pCilindrata;
        private DateTime pDataImmatricolazione;
        
        // costrutture
        public clsVeicoli()
        {
            pMarca = string.Empty;
            pColore = string.Empty;
            pCilindrata = 0;
            pModello = string.Empty;

            pDataImmatricolazione = DateTime.MinValue;
        }

        public string PMarca { get => pMarca; set => pMarca = value; }
        public string PColore { get => pColore; set => pColore = value; }
        public string PModello { get => pModello; set => pModello = value; }
        public uint PCilindrata { get => pCilindrata; set => pCilindrata = value; }
        public DateTime PDataImmatricolazione { get => pDataImmatricolazione; set => pDataImmatricolazione = value; }

        public string visualizzaVeicolo()
        {
            return $@"VEICOLO:\n
                - Marca {pMarca}\n
                - Modello {pModello}\n
                - Colore {pColore}\n
                - Cilindrata {pCilindrata.ToString()}";
        }

        public uint etaVeicolo()
        {
            return Convert.ToUInt16(DateTime.Now.Year - pDataImmatricolazione.Year);
        }

        // calcolo del bollo
        public double calcolaBollo()
        {
            double importo = 0.0;

            // età <= 5 --> 0.00
            if(etaVeicolo() > 5)
            {
                if (pCilindrata <= 1000)
                    importo = pCilindrata * 0.08;
                else if (pCilindrata <= 1999)
                    importo = pCilindrata * 0.11;
                else
                    importo = pCilindrata * 0.15;

            }

            return importo;
        }

        public double CalcolaConsumoMedio()
        {

        }

    }
}
