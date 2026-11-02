using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1101_modulo7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contatore c = Contatore.CreaContatore();

            c.Incrementa();
            c.Incrementa();

            Console.WriteLine("Valore contatore: " + c.Valore);

            c.Reset();

            Console.WriteLine("Dopo il reset: " + c.Valore);


            Logger logger = Logger.Instance;

            logger.Log("Programma avviato");
            logger.Log("Contatore incrementato");
            logger.Log("Contatore resettato");

            List<string> contatti = new List<string>();

            Dictionary<string, string> rubrica = new Dictionary<string, string>();

            contatti.Add("Luca");
            rubrica.Add("Luca", "3331234567");

            contatti.Add("Marco");
            rubrica.Add("Marco", "3337654321");

            logger.Log("Contatti aggiunti")

            Console.WriteLine("\nRubrica:");

            foreach (string nome in contatti)
                Console.WriteLine(nome + " - " + rubrica[nome]);
            

            Console.WriteLine("\nRicerca Luca:");

            if (rubrica.ContainsKey("Luca"))
                Console.WriteLine("Telefono: " + rubrica["Luca"]);
            else
                Console.WriteLine("Contatto non trovato");

            Console.WriteLine("\nRimozione Marco:");

            if (rubrica.ContainsKey("Marco"))
            {
                rubrica.Remove("Marco");
                contatti.Remove("Marco");

                Console.WriteLine("Contatto rimosso");
            }

            logger.Log("Contatto Marco rimosso");

            Console.WriteLine("\nRubrica aggiornata:");

            foreach (string nome in contatti)
                Console.WriteLine(nome + " - " + rubrica[nome]);

            logger.Log("Programma terminato");
        }
    }
}
