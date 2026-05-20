using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es24p52
{
    internal class Program
    {
        static int LeggiNumero(string messaggio)
        {
            int numero;
            bool isCorrect;
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
            // visualizzare i numeri dispari compresi nell'intervallo tra 2 interi positivi n1 e n2, entrambi forniti in ingresso con n2 > n1

            int n1 = LeggiNumero("Inserisci il primo numero");
            int n2 = LeggiNumero("Inserisci il secondo numero");

            while(n1 != n2 )
            {
                if ( n1 % 2 != 0)
                {
                    Console.WriteLine(n1);
                }
                n1++;
            }
        }
    }
}
