using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Tris
{
    internal class Program
    {
        Random rnd = new Random();
        static void Main(string[] args)
        {
            int a = rnd.Next(1, 6);
            int b = rnd.Next(1, 6);
            int c = rnd.Next(1, 6);

            Console.WriteLine($"{a}, {b}, {c}");

            if (a == b && b == c)
            {
                Console.WriteLine("Hai fatto tris");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Hai fatto coppia");
            }
        }
    }
}
