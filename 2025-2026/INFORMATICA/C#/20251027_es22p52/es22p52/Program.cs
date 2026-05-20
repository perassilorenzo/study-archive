using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace es22p52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // visualizzare 100 numeri pari partendo dal numero 2

            int i = 0;

            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
    }
}
