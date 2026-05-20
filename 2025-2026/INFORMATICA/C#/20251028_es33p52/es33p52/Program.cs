using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace es33p52
{
    internal class Program
    {
        static int LeggiNumero(string messaggio, bool Positivo = true)
        {
            int numero;
            bool isCorrect = true;

            do
            {
                Console.WriteLine(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero valido");
                    Console.Clear();
                    Console.ReadKey();
                }
                if (isCorrect && Positivo && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero valido");
                    Console.Clear();
                    Console.ReadKey();
                }
            } while (!isCorrect);
            return numero;
        }

        static void Main(string[] args)
        {
            // verificare se un numero introe postivio n fornito in ingresso è un numero deficiente

            int numero = LeggiNumero("Inserisci il numero da analizzare: ");
            bool stop = false;
            int i = 2;
            int somma = 0;


            while (!stop)
            {
                if (numero % i == 0)
                {
                    somma += i;
                }
                i++;
            }

            if (somma < numero)
            {
                Console.WriteLine("E' un numero deficiente");
            }
            else { Console.WriteLine("Non è un numero deficiente"); }

            Console.ReadKey();


        }
    }
}
