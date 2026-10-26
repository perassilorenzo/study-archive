using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio01
{
    public class clsVeicoli : clsAstratta
    {

        private string pMarca;
        private string pColore;
        private string pModello;
        private uint pCilindrata;
        private DateTime pDataImmatricolazione;

        // Costruttore
        public clsVeicoli()
        {
            pMarca = string.Empty;
            pColore = string.Empty;
            pCilindrata = 0;
            pModello = string.Empty;
            pDataImmatricolazione = DateTime.MinValue;
        }

        public string Marca { get => pMarca; set => pMarca = value; }
        public string Colore { get => pColore; set => pColore = value; }
        public string Modello { get => pModello; set => pModello = value; }
        public uint Cilindrata { get => pCilindrata; set => pCilindrata = value; }
        public DateTime DataImmatricolazione { get => pDataImmatricolazione; set => pDataImmatricolazione = value; }

        // Visualizza Info Veicolo
        public override string visualizzaVeicolo()
        {
            return $"VEICOLO : \n" +
                $"- Marca {pMarca} \n" +
                $"- Modello {pModello} \n" +
                $"- Colore {pColore} \n" +
                $"- Cilindrata {pCilindrata.ToString()} " +
                $" - Data Immatricolazione { pDataImmatricolazione.ToString(@"dd\/MM\/yyyy")}";

            //return $@"VEICOLO : 
            //    - Marca {pMarca} 
            //    - Modello {pModello} \n
            //    - Colore {pColore} \n
            //    - Cilindrata {pCilindrata.ToString()} 
            //    - Data Immatricolazione {pDataImmatricolazione.ToString(@"dd\/MM\/yyyy")}";
        }

        // Calcolo Età del Veicolo
        public uint etaVeicolo()
        {
            return Convert.ToUInt16( DateTime.Now.Year - pDataImmatricolazione.Year);
        }

        // Calcolo del Bollo
        public override double calcolaBollo()
        {
            double importo = 0.0;

            // Età <= 5 ==> 0.00€

            // Età > 0
            if (etaVeicolo() > 5 || pCilindrata > 2999)
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

        // Calcolo Assicurazione
        public double Assicurazione()
        {
            double importo = 0.0;

            if (pCilindrata <= 1999)
                importo = (pCilindrata * etaVeicolo()) / 10;
            else
                importo = (pCilindrata * etaVeicolo()) / 5;

            return importo;
        }

        // Calcolo Consumo Medio
        public double CalcolaConsumoMedio()
        {
            if (pCilindrata <= 1500)
                return 18; // 18 Km con un litro
            else if (pCilindrata <= 2500)
                return 13.8; // 13,8 Km con un litro
            else
                return 9.3;  // 9,3 Km con un litro
        }

        // Calcolo Costo di Viaggio

        public double CalcolaCostoViaggio(int kmPercorsi, double prezzoCarburante)
        {
            double kmPerLitro = CalcolaConsumoMedio();
            double numLitri = kmPercorsi / kmPerLitro;
            return numLitri * prezzoCarburante;
        }

    }
}
