using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_es4pag115
{
    internal class Program
    {
        static string[] Cognomi = { "Perrone", "Isaia", "Aigotti", "Frua", "Giraudo", "Grumeza", "Coccioni", "Kasneci", "Maffiotto", "Boggetti", "Sciolla", "Montepeloso", "Perassi", "Martelli", "Tosco", "Regis", "Stoppa", "Mandrile", "Zefi", "Zhala", "Zhu" };
        static string[] Nomi = { "Sirio", "Pietro", "Davide", "Mathias", "Loris", "Matteo", "Riccardo", "Erdi", "Andrea", "Leonardo", "Andrea", "Matteo", "Lorenzo", "Sara", "Gabriele", "Matteo", "Nicolò", "Tommaso", "Andrea", "Frenk", "Leon" };
        static void Main(string[] args)
        {
            Bubble(Cognomi, Nomi);
            PrintArray(Cognomi, Nomi);

            string cognome = LeggiStringa("Inserisci il cognome: ");
            string nome = LeggiStringa("Inserisci il nome: ");

            int pos = RicercaDicotomica(Cognomi, cognome);

            if (pos < 0 || Nomi[pos].CompareTo(nome) != 0)
            {
                Console.WriteLine("Nominativo non trovato");
            }
            else
            {
                Console.WriteLine($"Trovato in posizione {pos+1}");

            }

        }
        private static int RicercaDicotomica(string[] vettore, string nomeDaCercare)
        {
            int posizione = -1, min = 0, max = vettore.Length - 1;
            int meta;

            while (min <= max)
            {
                meta = (max + min) / 2;
                if (vettore[meta] == nomeDaCercare)
                {
                    return meta;
                }
                else
                {
                    if (nomeDaCercare.CompareTo(vettore[meta]) > 0)
                    {
                        min = meta + 1;
                    }
                    else // In questo caso nomeDaCercare sarà sicuramente più piccolo
                         // Se fosse stato = a vettore[i] sarei già uscito al return sopra
                    {
                        max = meta - 1;
                    }
                }
            }

            return posizione;
        }

        private static string LeggiStringa(string v)
        {
            Console.Write(v);
            return Console.ReadLine();
        }

        private static void PrintArray(string[] cognomi, string[] nomi)
        {
            for (int i = 0; i < cognomi.Length; i++)
            {
                Console.WriteLine(cognomi[i] + " " + nomi[i]);
            }
        }

        private static void Bubble(string[] array, string[] array2)
        {
            int i = -1;
            bool scambio;

            do
            {
                i++;
                scambio = false;
                for (int j = array.Length - 2; j >= i; j--)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        string temp2 = array2[j];
                        array2[j] = array2[j + 1];
                        array2[j + 1] = temp2;

                        scambio = true;
                    }
                }
            } while (scambio && i < array.Length - 1);

        }
    }
}
