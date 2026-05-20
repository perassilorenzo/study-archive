using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BollettaTelefonica
{
    internal class Program
    {
        static void Main(string[] args) //questo main con parentesi c'è un vettore senza grandezza perché ci sono le quadre (i vettori in c# non hanno lunghezza) un vettore di stringhe, è un parametro,che servono al main i parametri per venire avviato con dei parametri dall'utente questo è il modo per farlo
        {
            int numeroScatti;
            double costo;

            do {

                Console.Clear();
                Console.Write("Inserisci il numero di scatti (Maggiore di 0): ");
                numeroScatti = Convert.ToInt32(Console.ReadLine());

            } while (numeroScatti <= 0);

            
            if(numeroScatti <= 30)
            {
                costo = (numeroScatti * 0.2) + 2.5;
            }
            else if (numeroScatti <30 && numeroScatti <= 100)
            {
                costo = 6 + (numeroScatti - 30) * 0.15 + 2.5;
            }
            else 
            {
                costo = 16.5 + (numeroScatti - 100) * 0.10 + 2.5;
            }
            Console.WriteLine("Costo totale: " + costo);
            
            Console.ReadKey();
        }
    }
}
