using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio01
{
    public class clsAuto : clsVeicoli
    {

        private uint pNumPorte;
        private bool pElettrica;

        public clsAuto()
        {
            pNumPorte = 0;
            pElettrica = false;
        }

        public clsAuto(string marca,
                        string colore,
                        string modello,
                        uint cilindrata,
                        DateTime dataImm,
                        uint nporte,
                        bool elettrica)
        {

            this.Marca = marca;
            this.Colore = colore;
            this.Modello = modello;
            this.Cilindrata = cilindrata;
            this.DataImmatricolazione = dataImm;

            this.pNumPorte = nporte;
            this.pElettrica = elettrica;

        }

        public uint NumPorte { get => pNumPorte; set => pNumPorte = value; }
        public bool Elettrica { get => pElettrica; set => pElettrica = value; }

        public override string visualizzaVeicolo()
        {
            return base.visualizzaVeicolo() + " " +
                    $"- Numero Porte : {pNumPorte} " +
                    $"- Elettrica : {pElettrica}";
        }


    }
}
