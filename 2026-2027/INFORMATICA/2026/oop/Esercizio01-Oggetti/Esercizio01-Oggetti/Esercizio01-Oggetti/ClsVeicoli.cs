using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio01_Oggetti
{
    public class ClsVeicoli
    {
        private string pMarca;
        private string pColore;
        private string pModello;
        private uint pCilindrata;
        private DateTime pDataImmatricolazione;
        
        //Costruttore
        public ClsVeicoli()
        {
            pMarca = string.Empty;
            pColore = string.Empty;
            pModello = string.Empty;
            pCilindrata = 0;
            pDataImmatricolazione = DateTime.MinValue;
        }

        public string Marca { get => pMarca; set => pMarca = value; }
        public string Colore { get => pColore; set => pColore = value; }
        public string Modello { get => pModello; set => pModello = value; }
        public uint Cilindrata { get => pCilindrata; set => pCilindrata = value; }
        public DateTime DataImmatricolazione { get => pDataImmatricolazione; set => pDataImmatricolazione = value; }

        public string visualizzaVeicolo()
        {
            return $"Veicolo: \n- Marca: {pMarca}\n- Colore: {pColore}\n- Modello: {pModello}\n" +
                $"- Cilindrata: {pCilindrata.ToString()}\n-Data Immatricolazione {pDataImmatricolazione.ToString(@"dd\/MM\/yyyy")}";
        }

        public uint etaInfo()
        {
            return Convert.ToUInt16(DateTime.Now.Year - pDataImmatricolazione.Year);
        }

        //calcolo del bollo
        public double calcolaBollo()
        {
            double importo = 0.0;

            if(etaInfo() > 5)
            {
                if(pCilindrata <= 1000)
                {
                    importo = pCilindrata * 0.08;
                }
                else if(pCilindrata <= 1999)
                {
                    importo = pCilindrata * 0.11;
                }
                else
                {
                    importo = pCilindrata * 0.15;
                }
            }

            return importo;
        }

        //Calcolo del consumo medio
        public double CalcolaConsumoMedio()
        {
            if(pCilindrata <= 1500)
            {
                return 18;
            }
            else if(pCilindrata <= 2500)
            {
                return 13.8;
            }
            else
            {
                return 9.3;
            }
        }

        public double CalcolaCostoViaggio(int kmPercorsi, double prezzoCarburante)
        {
            double kmPerLitro = CalcolaConsumoMedio();
            double numLitri = kmPercorsi/kmPerLitro;
            return numLitri * prezzoCarburante;
        }
    }
}
