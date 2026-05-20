using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_es28pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //convertire un numero binario fornito in ingresso (e di cui è fornita la sua lunghezza n) nel decimale corrispondente

            int n = LeggiNumero("Inserire la lunghezza del vettore binario");
            int[] array = CaricaArray(n);
            int solution = BinaryInt(array);
            Console.WriteLine(solution);
        }

        private static int BinaryInt(int[] array)
        {
            int n = 0;

            for (int i = 0; i < array.Length; i++)
            {
                n = n * 2 + array[i];
            }

            return n;
        }

        private static int[] CaricaArray(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                int bit;
                do
                {
                    bit = LeggiNumero($"Inserisci il bit numero {i + 1} (0 o 1)");
                } while (bit != 0 && bit != 1);

                array[i] = bit;
            }
            return array;
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
                    Console.WriteLine("Devi inserire un numero valido");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && n < 0)
                {
                    isCorrect= false;
                    Console.WriteLine("Devi inserire un numero maggiore di zero");
                }

            } while (!isCorrect);

            return n;
        }
    }
}
