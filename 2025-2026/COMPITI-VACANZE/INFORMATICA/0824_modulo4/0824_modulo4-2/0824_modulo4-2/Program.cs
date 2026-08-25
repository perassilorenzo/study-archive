using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0824_modulo4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            Console.WriteLine(logger1 == logger2);

            logger1.Log("Program starts");
            logger2.Log("Second message");

            Configurazione config = Configurazione.Instance;
            Console.WriteLine(config.Ambiente);
            Console.WriteLine(config.Versione);
        }
    }
}
