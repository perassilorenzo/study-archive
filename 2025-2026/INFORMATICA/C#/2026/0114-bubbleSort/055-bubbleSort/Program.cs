using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_bubbleSort
{
    internal class Program
    {
        static string[] array = { "Barbara", "Alberto", "Paola", "Domenico", "Vincenzo", "Beatrice" };
        static void Main(string[] args)
        {
            Bubble(array);
            Console.ReadKey();
        }
        static void Bubble(string[] array)
        {

            int i = -1;
            bool scambio;

            do
            {
                i++;
                scambio = false;
                for (int j = array.Length - 2; j >= i; j--)
                {
                    if (array[j].CompareTo(array[j+1]) > 0)
                    {
                        string temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;

                        scambio = true;
                    }
                }
            } while (scambio && i < array.Length - 1);

            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k]);
            }
        }
    }
}
