using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo2b
{
    public class Prodotto
    {
        private string nome;
        private double prezzo;

        public Prodotto(string nome, double prezzo)
        {
            this.Nome = nome;
            this.Prezzo = prezzo;
        }

        public string Nome
        {
            get { return  nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Il nome non può essere vuoto.");
                nome = value;
            }
        }

        public double Prezzo
        {
            get { return prezzo; }
            set
            {
                if (value <= 0) throw new ArgumentException("Il prezzo deve essere maggiore di 0.");
                prezzo = value;
            }
        }

        public void AggiornaPrezzo(double prezzo)
        {
            Prezzo = prezzo;
        }

        public void AggiornaPrezzo(double prezzo, double sconto)
        {
            Prezzo = prezzo * sconto / 100;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

//+-----------------------------------------+
//|                 Prodotto                |
//+-----------------------------------------+
//| - nome : string                         |
//| - prezzo : double                       |
//+-----------------------------------------+
//| + Nome : string                         |
//| + Prezzo : double                       |
//+-----------------------------------------+
//| + Prodotto(nome, prezzo)                |
//| + AggiornaPrezzo(double) : void         |
//| + AggiornaPrezzo(double, double) : void |
//| + ToString() : string                   |
//+-----------------------------------------+