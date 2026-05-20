using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es26p52
{
    internal class Program
    {
        static int LeggiNumero(string messaggio, bool soloPositvi = true)
        {
            int numero;
            bool isCorrect = true;

            do
            {
                Console.WriteLine(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero) )
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero valido");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositvi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero valido");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!isCorrect);
            return numero;
        }

        static void Main(string[] args)
        {
            // calcolare il fattoriale di un numero n in ingresso, con n > 0

            int n = LeggiNumero("Inserire il numero di inserimenti");
            int fattoriale = 0;

            for (int i = 0;  i < n; i++)
            {
                for(int j = 0; j <= n; j++)
                {
                    fattoriale *= j;
                }
            }

            Console.WriteLine(fattoriale);
        }
    }
}
