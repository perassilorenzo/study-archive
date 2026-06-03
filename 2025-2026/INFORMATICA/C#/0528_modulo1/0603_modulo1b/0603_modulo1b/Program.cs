using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo1b
{
    public class ContoBancario
    {
        private string numeroConto;
        private double saldo;

        public ContoBancario(string numeroConto, double saldo)
        {
            this.NumeroConto = numeroConto;
            if (saldo >= 0) this.Saldo = saldo;
            else this.Saldo = 0;
        }

        public string NumeroConto
        {
            get { return numeroConto; }
            set { numeroConto = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0) saldo = value;
                else Console.WriteLine("Il saldo deve essere positivo");
            }
        }

        public void Deposita(double importo)
        {
            if (importo > 0) Saldo += importo;
            else Console.WriteLine("Importo non valido");
        }

        public void Preleva(double importo)
        {
            if (importo >= 0)
            {
                Console.WriteLine("Importo non valido");
                return;
            }

            if (Saldo - importo >= 0) Saldo -= importo;
            else Console.WriteLine("Saldo insufficiente");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ContoBancario conto = new ContoBancario("XX999", 100);

            conto.Deposita(100);
            conto.Preleva(200);

            Console.WriteLine($"Conto finale: {conto.Saldo}");
        }
    }
}

// ======== UML ========

//+-------------------------------------+
//|                 Conto               |
//+-------------------------------------+
//| - numeroConto: string               |
//| - saldo: double                     |
//+-------------------------------------+
//| +ContoBancario(numeroConto, saldo)  |
//| +NumeroConto: string {get; set;}    |
//| +Saldo: double {get; set;}          |
//| +Deposita(importo)                  |
//| +Preleva(importo)                   |
//+-------------------------------------+
