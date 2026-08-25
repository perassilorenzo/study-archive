using _0824_modulo3_a;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0824_modulo3_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creazione istanze
            Contatore c1 = new Contatore();
            Contatore c2 = new Contatore();

            // ce ne aspettiamo 2
            Console.WriteLine(Contatore.TotaleIstanza);
            
            // distruzione / reset istanze
            Contatore.Reset();

            // creazione istanza 
            Contatore c3 = new Contatore();

            // ce ne aspettiamo 1
            Console.WriteLine(Contatore.TotaleIstanza);
        }
    }
}
