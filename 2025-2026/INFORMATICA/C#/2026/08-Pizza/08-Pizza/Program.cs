using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double budget, costoPizza;
            int amici;

            do
            {
                do
                {
                    Console.Write("Inserire il budget iniziale (maggiore di 0): ");
                    budget = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Inserire il numero di amici (maggiore di 0): ");
                    amici = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inserire il costo di una pizza: ");
                    costoPizza = Convert.ToDouble(Console.ReadLine());
                } while (budget < 0 || amici < 0 || costoPizza < 0);

            } while (budget < amici * costoPizza);

            Console.WriteLine("Il resto delle pizze equivale a " + (budget - (amici * costoPizza)));
            Console.ReadKey();
        }
       
    }
}
