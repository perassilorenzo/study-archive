using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110_oop_3_data_orario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data(10, 11, 2026);

            Console.WriteLine("Data: " + d.ToString());
            Console.WriteLine("Bisestile: " + d.Bisestile());
            Console.WriteLine("Giorno: " + d.Giorno());

            d.Domani();
            Console.WriteLine("Domani: " + d.ToString());

            d.Ieri();
            Console.WriteLine("Ieri: " + d.ToString());


            DataOra o = new DataOra(10, 11, 2026, 16, 30, 45);

            Console.WriteLine("\nData e ora: " + o.ToString());

            o.Leggi(12, 5, 2026, 14, 20, 10);

            Console.WriteLine("Nuova data e ora: " + o.ToString());
        }
    }
}
