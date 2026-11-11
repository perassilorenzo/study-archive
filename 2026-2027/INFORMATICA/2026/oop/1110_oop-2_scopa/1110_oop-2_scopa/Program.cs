using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110_oop_2_scopa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il nome del primo giocatore: ");
            string nome1 = Console.ReadLine();

            Console.Write("Inserisci il nome del secondo giocatore: ");
            string nome2 = Console.ReadLine();

            Mazzo mazzo = new Mazzo();
            mazzo.Mescola();

            Giocatore g1 = new Giocatore(nome1);
            Giocatore g2 = new Giocatore(nome2);

            for (int i = 0; i < 3; i++)
            {
                g1.Lettura().Add(mazzo.Estrai());
                g2.Lettura().Add(mazzo.Estrai());
            }

            Console.WriteLine("\nCarte di " + nome1 + ":");

            foreach (Carta c in g1.Lettura())
            {
                int valore;
                string seme;

                c.Lettura(out valore, out seme);
                Console.WriteLine(valore + " di " + seme);
            }

            Console.WriteLine("\nCarte di " + nome2 + ":");

            foreach (Carta c in g2.Lettura())
            {
                int valore;
                string seme;

                c.Lettura(out valore, out seme);
                Console.WriteLine(valore + " di " + seme);
            }

            Console.WriteLine("\n" + nome1 + ", scegli una carta da giocare (0-2):");
            int indice = int.Parse(Console.ReadLine());

            Carta giocata = g1.Gioca(indice);

            if (giocata != null)
            {
                int valore;
                string seme;

                giocata.Lettura(out valore, out seme);
                Console.WriteLine(nome1 + " ha giocato: " + valore + " di " + seme);
            }
            else
                Console.WriteLine("Indice non valido!");
        }
    }
}
