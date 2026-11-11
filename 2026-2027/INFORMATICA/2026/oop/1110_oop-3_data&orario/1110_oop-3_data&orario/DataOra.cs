using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110_oop_3_data_orario
{

    public class DataOra : Data
    {
        private int ore;
        private int minuti;
        private int secondi;

        public DataOra() : base()
        {
            ore = 0;
            minuti = 0;
            secondi = 0;
        }

        public DataOra(int g, int m, int a) : base(g, m, a)
        {
            ore = 0;
            minuti = 0;
            secondi = 0;
        }

        public DataOra(int g, int m, int a, int o, int min, int s) : base(g, m, a)
        {
            ore = o;
            minuti = min;
            secondi = s;
        }

        public override string ToString()
        {
            return base.ToString() + " " + ore + ":" + minuti + ":" + secondi;
        }

        public void Leggi(int g, int m, int a, int o, int min, int s)
        {
            base.Leggi(g, m, a);

            ore = o;
            minuti = min;
            secondi = s;
        }

        public void Scrivi(out int g, out int m, out int a, out int o, out int min, out int s)
        {
            base.Scrivi(out g, out m, out a);

            o = ore;
            min = minuti;
            s = secondi;
        }
    }
}
