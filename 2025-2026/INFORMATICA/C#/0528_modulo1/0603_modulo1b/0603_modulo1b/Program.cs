using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603_modulo1b
{
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
