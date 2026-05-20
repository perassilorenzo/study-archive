using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int giorno, mese, anno;
            bool cicla = false;

            do
            {
                if (cicla)
                {
                    Console.Clear();
                    cicla = false;
                }

                Console.Write("Inserisci il giorno: ");
                giorno = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserisci il mese: ");
                mese = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserisci il anno: ");
                anno = Convert.ToInt32(Console.ReadLine());

                if (mese <= 0 || mese > 12)
                {
                    cicla = true;
                }
                else
                {
                    switch (mese) 
                    {
                        case 2:
                            bool bisestile = false;
                            if (anno % 4 == 0)
                            {
                                if (anno % 100 == 0)
                                {
                                    if (anno % 400 == 0)
                                    {
                                        bisestile = true;
                                    }
                                }
                                else bisestile = true;
                            }
                            if (bisestile && giorno > 29)
                            {
                                cicla = true;
                            }
                            if (giorno > 28 && !bisestile)
                            {
                                cicla = true;
                            }
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (giorno > 30)
                            {
                                cicla = true;
                            }
                            break;

                        default:
                            if (giorno > 31)
                            {
                                cicla = true;
                            }
                            break; 
                    }
                }
            }
            while (cicla == true);

            Console.WriteLine("La data inserità è corretta!\n" + giorno + "/" + mese + "/" + anno);
            Console.ReadKey();
        }
    }
}
