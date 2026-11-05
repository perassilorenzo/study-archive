using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio01
{
    public class clsMoto : clsVeicoli
    {

        private string pTipoCambio;
        private string pTipoMotore;

        public clsMoto()
        {
            pTipoCambio = string.Empty;
            pTipoMotore = string.Empty;
        }

        public clsMoto(string marca,
                        string colore,
                        string modello,
                        uint cilindrata,
                        DateTime dataImm,
                        string cambio,
                        string motore)
        {

            this.Marca = marca;
            this.Colore = colore;
            this.Modello = modello;
            this.Cilindrata = cilindrata;
            this.DataImmatricolazione = dataImm;

            this.pTipoCambio = cambio;
            this.pTipoMotore = motore;

        }

        public string TipoCambio { get => pTipoCambio; set => pTipoCambio = value; }
        public string TipoMotore { get => pTipoMotore; set => pTipoMotore = value; }

        public override string visualizzaVeicolo()
        {
            return base.visualizzaVeicolo() + " " +
                    $"- Tipo Cambio : {pTipoCambio} " +
                    $"- Tipo Motore : {pTipoMotore}";
        }

        // Calcolo del Bollo
        public override double calcolaBollo()
        {
            double importo = 0.0;

            // Età <= 5 ==> 0.00€

            // Età > 0
            if (etaVeicolo() > 3 || this.Cilindrata > 999)
            {
                if (this.Cilindrata <= 125)
                    importo = this.Cilindrata * 0.3;
                else if (this.Cilindrata <= 599)
                    importo = this.Cilindrata * 0.8;
                else
                    importo = this.Cilindrata * 1.1;
            }

            return importo;
        }

    }
}
