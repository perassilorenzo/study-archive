using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es27p52
{
    internal class Program
    {
        static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            int numero;
            bool isCorrect = true;

            do
            {
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = true ;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero valido");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero valido");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!isCorrect);
            return numero;
        }

        static void Binario(int n)
        {
            string binario = null;

            while (n == 0)
            {
                if(n % 2 == 0)
                {
                    n /= 2;
                    binario = "0" + binario;
                }
                else
                {
                    n = (n - 1) / 2;
                    binario = "1" + binario;
                }
            }

            Console.WriteLine(binario);
        }
        


        static void Main(string[] args)
        {
            // converire un numero n intero positivo fornito in inresso nel numero binario corrispondente

            int n = LeggiNumero("Inserire il numero da convertire");
            Binario(n);


        
        
        
        }

    }
}
