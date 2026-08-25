using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0825_modulo6_c
{
    internal class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public int Id { get; set; }

        public Studente(string nome, string cognome, int eta, int id)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
            Id = id;
        }
    }
}
