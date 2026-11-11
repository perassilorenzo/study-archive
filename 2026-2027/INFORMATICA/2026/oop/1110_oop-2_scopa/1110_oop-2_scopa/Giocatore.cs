using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110_oop_2_scopa
{
    public class Giocatore
    {
        private string nome;
        private Mano mano;
        private Mano prese;

        public Giocatore(string nome)
        {
            this.nome = nome;
            mano = new Mano();
            prese = new Mano();
        }

        public List<Carta> Lettura()
        {
            return mano.Lettura();
        }

        public List<Carta> Prese()
        {
            return prese.Lettura();
        }

        public Carta Gioca(int indice)
        {
            return mano.Gioca(indice);
        }
    }
}
