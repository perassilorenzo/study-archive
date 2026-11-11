using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110_oop_2_scopa
{
    public class Mazzo
    {
        private List<Carta> carte;

        public Mazzo()
        {
            carte = new List<Carta>();

            string[] semi = { "Denari", "Coppe", "Spade", "Bastoni" };

            for (int s = 0; s < 4; s++)
                for (int v = 1; v <= 10; v++)
                    carte.Add(new Carta(v, semi[s]));
        }

        public void Mescola()
        {
            Random casuale = new Random();

            for (int i = 0; i < carte.Count; i++)
            {
                int j = casuale.Next(carte.Count);

                Carta temp = carte[i];
                carte[i] = carte[j];
                carte[j] = temp;
            }
        }

        public Carta Estrai()
        {
            if (carte.Count == 0)
                return null;

            Carta carta = carte[0];
            carte.RemoveAt(0);

            return carta;
        }
    }
}
