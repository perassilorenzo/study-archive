using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Numeri_Dispari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 0;
            do
            {
                n1 = Convert.ToInt32(Console.ReadLine());
                n2 = Convert.ToInt32(Console.ReadLine());
            } while (n2 > n1);

            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
