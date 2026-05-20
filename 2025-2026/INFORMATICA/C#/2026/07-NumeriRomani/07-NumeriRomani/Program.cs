using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_NumeriRomani
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;

            do
            {
                Console.Write("Inserisci un numero (1-1000): ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 1 || numero > 1000)
                {
                    Console.WriteLine("Numero non valido, riprova!");
                }

            } while (numero < 1 || numero > 1000);

            string romano = "";

            // mille
            if (numero == 1000) romano += "M";

            // centinaia
            if (numero >= 900 && numero < 1000) { romano += "CM"; numero -= 900; }
            if (numero >= 500 && numero < 900) { romano += "D"; numero -= 500; }
            if (numero >= 400 && numero < 500) { romano += "CD"; numero -= 400; }
            while (numero >= 100)
            {
                romano += "C";
                numero -= 100;
            }

            // decine
            if (numero >= 90 && numero < 100) { romano += "XC"; numero -= 90; }
            if (numero >= 50 && numero < 90) { romano += "L"; numero -= 50; }
            if (numero >= 40 && numero < 50) { romano += "XL"; numero -= 40; }
            while (numero >= 10)
            {
                romano += "X";
                numero -= 10;
            }

            // unità
            if (numero == 9) { romano += "IX"; numero -= 9; }
            if (numero >= 5 && numero < 9) { romano += "V"; numero -= 5; }
            if (numero == 4) { romano += "IV"; numero -= 4; }
            while (numero >= 1)
            {
                romano += "I";
                numero -= 1;
            }

            Console.WriteLine("Numero romano: " + romano);

            Console.ReadKey();





        }
    }
}
