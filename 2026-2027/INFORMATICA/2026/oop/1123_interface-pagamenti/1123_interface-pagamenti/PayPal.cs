using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1123_interface_pagamenti
{
    internal class PayPal : IPagamento
    {
        public void EffettuaPagamento(decimal importo)
        {
            Console.WriteLine($"Pagamento effettuato tramite PayPal di €{importo}");    
        }
    }
}
