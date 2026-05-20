using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_es5pag115
{
    internal class Program
    {
        static string[] cognomi = { "Donnarumma", "Bastoni", "DiLorenzo", "Theo", "Barella", "Tonali", "Chiesa", "Leao", "Vlahovic", "Giroud" };
        static string[] nomi = { "Gianluigi", "Alessandro", "Giovanni", "Hernandez", "Nicolò", "Sandro", "Federico", "Rafael", "Dusan", "Olivier" };
        static string[] squadre = { "PSG", "PSG", "PSG", "Milan", "Milan", "Milan", "Juventus", "Milan", "Juventus", "Juventus" };

        static void Main(string[] args)
        {
            string[] cognomiOrdinati = new string[cognomi.Length];
            string[] nomiOrdinati = new string[cognomi.Length];
            
            string squadra = LeggiStringa("Inserisci la squadra:");

            int n = CopiaVettore(cognomi, squadre, squadra, cognomiOrdinati);
            CopiaVettore(nomi, squadre, squadra, nomiOrdinati);

            PrintArray(cognomiOrdinati, nomiOrdinati);

            // supponiamo non ci siano duplicati
            Bubble(cognomiOrdinati, nomiOrdinati);
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
        private static void PrintArray(string[] cognomi, string[] nomi)
        {
            for (int i = 0; i < cognomi.Length; i++)
            {
                Console.WriteLine(cognomi[i] + " " + nomi[i]);
            }
        }

        private static int CopiaVettore(string[] nominativo, string[] squadre, string squadra, string[] destinazione)
        {
            int[] pos = new int[nominativo.Length];
            int n = RicercaSequenziale(nominativo, pos, squadra);

            for (int i = 0; i < n; i++)
            {
                destinazione[i] = squadre[pos[i]];
            }

            return n;
        }
        private static int RicercaSequenziale(string[] vettore, int[] vettorePosizioni, string elemento)
        {
            int nElementi = 0;

            for (int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] == elemento)
                {
                    vettorePosizioni[nElementi] = i;
                    nElementi++;
                }
            }

            return nElementi;
        }
        private static string LeggiStringa(string v)
        {
            Console.Write(v);
            return Console.ReadLine();
        }
    }
}
