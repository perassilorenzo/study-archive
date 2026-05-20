using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laRicercaSequenziale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //la ricerca sequanziale

            string[] v = new string[] { "Rossi", "Gallo", "Devirgiolio", "Melandri", "Fabbri", "Chiera"};

            Console.WriteLine("Inserisci un nome da cercare");
            string nome = Console.ReadLine();

            int pos = RicercaSequenziale(v, nome);

            if (pos == -1)
            {
                Console.WriteLine($"Nome: {nome} NON presente!");
            }
            else
            {
                Console.WriteLine($"Nome: {nome} TROVATO in posizione: {pos+1}");
            }
        }

        private static int RicercaSequenziale(string[] v, string nome)
        {
            int i = 0;
            
            // while (v[i] != nome && i < v.Length)

            while (!(v[i] == nome || i == v.Length - 1))
            {
                i++;
            }

            if (v[i] == nome) { return i; }
            else { return -1; }
        }
    }   
}
