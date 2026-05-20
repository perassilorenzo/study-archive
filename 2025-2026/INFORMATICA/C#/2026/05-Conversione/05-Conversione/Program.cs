using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Conversione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, giorno, mese;

            do
            {
                Console.Write("Inserire il numero in ingresso: ");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero < 1 & numero > 365);

            if (numero < 32)
            {
                giorno = numero;
                mese = 1; 
            }
            else if (numero < 60)
            {
                giorno = numero - 31;
                mese = 2;
            }
            else if (numero < 91)
            {
                giorno = numero - 59;
                mese = 3;
            }
            else if (numero < 121)
            {
                giorno = numero - 90;
                mese = 4;
            }
            else if (numero < 152)
            {
                giorno = numero - 120;
                mese = 5;
            }
            else if (numero < 182)
            {
                giorno = numero - 151;
                mese = 6;
            }
            else if (numero < 213)
            {
                giorno = numero - 181;
                mese = 7;
            }
            else if (numero < 244)
            {
                giorno = numero - 212;
                mese = 8;
            }
            else if (numero < 274)
            {
                giorno = numero - 243;
                mese = 9;
            }
            else if (numero < 305)
            {
                giorno = numero - 273;
                mese = 10;
            }
            else if (numero < 335)
            {
                giorno = numero - 304;
                mese = 11;
            }
            else
            {
                giorno = numero - 334; 
                mese = 12;
            }

            Console.WriteLine("La data è " + giorno + "/" + mese);

            Console.ReadKey();

        }
    }
}
