using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicercaDicotomica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ricerca dicotomica a pagina 96 del libro

            string[] array = { "Agosti", "Barbieri", "Bianchi", "Colombo", "Conti", "De Luca", "Esposito", "Ferri", "Fontana", "Galli", "Gentile", "Greco", "Lombardi", "Marini", "Martini", "Moretti", "Ricci", "Rossi", "Russo", "Villa" };
            string nameToSearch = "Conti";

            int pos = RicercaDicotomica(array, nameToSearch);

            if (pos == -1) Console.WriteLine($"{nameToSearch} non presente nell'insieme");
            else Console.WriteLine($"{nameToSearch} è stato trovato alla posizione {pos+1}");
        }

        private static int RicercaDicotomica(string[] array, string nameToSearch)
        {
            int pos = -1, min = 0, max = array.Length-1;
            int meta;

            while (min <= max)
            {
                meta = (max + min) / 2;
                
                if (array[meta] == nameToSearch)
                {
                    return meta;
                }
                else
                {
                    if (nameToSearch.CompareTo(array[meta]) > 0)
                    {
                        min = meta + 1;
                    }
                    else    //in questo caso nametosearch sarà sicuramente più piccolo
                            //se fosse stato == array[i] sarei già uscito al return prima
                    {
                        max = meta - 1;
                    }
                }
            }
            return pos;
        }
    }
}