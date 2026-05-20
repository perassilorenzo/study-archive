using System;

namespace _048_es31pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // visualizzare i numeri perfetti compresi tra 1 e 10000

            for (int i = 1; i <= 10000; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine($"Il numero {i} è un numero perfetto");
                }
            }
        }

        private static bool IsPerfect(int n)
        {
            int somma = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    somma += i;
                }
            }

            return somma == n;
        }
    }
}
