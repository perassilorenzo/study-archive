using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0921_oop
{
    internal class Persona
    {
        private string nome;
        private string cognome;
        private int eta;

        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        
        public string Cognome
        {
            get => cognome;
            set => cognome = value;
        }
        
        public int Eta
        {
            get => eta;
            set
            {
                if (value > 0)
                {
                    eta = value;
                }
            }
        }
        
        public Persona(string nome, string cognome, int eta)
        {
            // uso le property
            Nome = nome;
            Cognome = cognome;
            Eta = eta;

            //// non si usano gli attributi
            //this.nome = nome;
            //this.cognome = cognome;
            //this.eta = eta;
        }
    }
}
