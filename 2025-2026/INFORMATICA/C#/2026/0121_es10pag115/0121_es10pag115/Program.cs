using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0121_es10pag115
{
    internal class Program
    {
        static string[] titoli = { "Inception", "Avatar", "Shutter Island", "The Social Network", "Hugo", "The Avengers" };
        static string[] registi = { "Christopher Nolan", "James Cameron", "Martin Scorsese", "David Fincher", "Martin Scorsese", "Joss Whedon" };
        static int[] anni = { 2010, 2009, 2010, 2010, 2011, 2012 };

        static void Main(string[] args)
        {
            // esercizio 10 pagina 115
            // le informazioni riguardanti i dvd di una videoteca sono registrate in una serie di vettori di lunghezza n.
            // visualizzaree i titoli dei dve pubblicati tra il 2010 e il 2012 e diretti da un regista di cui di fornisce in ingresso il nominativo

            Console.WriteLine("Inserisci il nome del regista");
            string registra = Console.ReadLine();

            int anno = LeggiNumero("Inserisci l'anno");
        }

        private static int LeggiNumero(string v, bool soloPositivi = true, int min = 1800)
        {
            int n;
            bool isCorrect;

            do
            {
                Console.WriteLine(v);
                if (int.TryParse(Console.ReadLine(), out n){
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Inserisci un valore valido");
                    Console.Clear();
                    Console.ReadKey();
                }
                if (isCorrect && n > 1900 && n < 2027)
                {
                    Console.WriteLine("Devi inserire una data valida");
                    Console.Clear();
                    Console.ReadKey();
                }
            } while (!isCorrect);

            return n;
        }
    }   
}
