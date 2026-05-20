using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_es27pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // convertire un numero n intero postivi fornito in ingreso nel numero nìbinatio corrispondente

            int n = LeggiNumero("Inserire un numero per trarne il corrispondente binario");
            string binary = IntBinary(n);
            Console.WriteLine($"Il numero {n} in binario è: {binary}");
        }

        private static string IntBinary(int n)
        {
            if (n == 0) return "0";

            string binary = "";
            int temp = n;

            while (temp > 0)
            {
                if (temp % 2 == 0)
                    binary = "0" + binary;
                else
                    binary = "1" + binary;

                temp /= 2;
            }

            return binary;
        }

        private static int LeggiNumero(string v, bool soloPositivi = true)
        {
            int n;
            bool isCorrect;

            do
            {
                if (int.TryParse(Console.ReadLine(), out n))
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
                if (isCorrect && soloPositivi && n < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero maggiore di zero");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return n;
        }
    }
}
