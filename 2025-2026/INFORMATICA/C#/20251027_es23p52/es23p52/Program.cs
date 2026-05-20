using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es23p52
{
    internal class Program
    {
        static int LeggiNumero(string messaggio)
        {
            int numero;
            bool isCorrect = true;

            do
            {
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido");
                    Console.ReadKey();
                    Console.Clear();
                }
                
            } while (!isCorrect);
            return numero;
        }
        static void Main(string[] args)
        {
            // visualizzare i numeri pari compresi nell'intervallo tra 1 ed un numero intero positivo n fornito in ingresso

            int numero = LeggiNumero("Inserire il numero di ingressi");

            for (int i = 0; i < numero; i++)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
