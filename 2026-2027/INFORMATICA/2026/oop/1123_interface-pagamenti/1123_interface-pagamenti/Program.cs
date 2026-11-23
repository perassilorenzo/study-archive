using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1123_interface_pagamenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BonificoBancario b = new BonificoBancario();
            PayPal p = new PayPal();
            CartaDiCredito c = new CartaDiCredito();

            Console.OutputEncoding = Encoding.UTF8;

            b.EffettuaPagamento(123.4m);
            p.EffettuaPagamento(15.3m);
            c.EffettuaPagamento(9.32m);
        }
    }
}
