using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110_oop_2_scopa
{
    public class Mano
    {
        private List<Carta> carte;

        public Mano()
        {
            carte = new List<Carta>();
        }

        public List<Carta> Lettura()
        {
            return carte;
        }

        public Carta Gioca(int indice)
        {
            if (indice < 0 || indice >= carte.Count)
                return null;

            Carta carta = carte[indice];
            carte.RemoveAt(indice);

            return carta;
        }
    }
}
