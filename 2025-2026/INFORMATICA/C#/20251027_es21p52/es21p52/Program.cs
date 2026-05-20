using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es21p52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // cercare il valore più grande tra n valori interi forniti in ingresso, supponendo che anche il valore di n, intero e positivo, venga fornito in input


            Console.WriteLine("Inserire il numero di inserimenti");
            int n = Convert.ToInt32(Console.ReadLine());
            int maggiore = int.MinValue;
            int inserimento;

            for (int i = 0;  i < n; i++)
            {
                Console.WriteLine($"Inserire il {i}' valore");
                inserimento = Convert.ToInt32(Console.ReadLine());

                if (inserimento > maggiore)
                {
                    maggiore = inserimento;
                }
            }

            Console.WriteLine($"Il numero maggiore tra quelli inseriti è {maggiore}");
            Console.ReadKey();
        }
    }
}
