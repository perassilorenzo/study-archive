using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_RicercaBlocchi
{
    internal class Program
    {
        bool esci = false;
        static void Main(string[] args)
        {
            bool esci = false;
            bool trovato = false;
            int n = LeggiNumero("Inserire la dimensione del vettore");
            int[] array = new int[n];

            int element = LeggiNumero("Inserire l'elemento da ricercare");
            CaricaArray(array);
            int lunghezzaBlocco = Convert.ToInt32(Math.Sqrt(n));

            int i = lunghezzaBlocco - 1;

            do
            {
                if (array[i] == element)
                {
                    trovato = true;
                }
                else
                {
                    if (array[i] > element)
                    {
                        EsaminaBlocco(array, i, lunghezzaBlocco, trovato, element, esci);
                    }
                    else
                    {
                        i += lunghezzaBlocco;
                    }
                }
            } while (!(trovato || esci || i > n - 1));

            if (trovato)
            {
                Console.WriteLine($"Elemento trovato in posizione {i}");
            }
            else
            {
                if (esci)
                {
                    Console.WriteLine("Elemento non trovato");
                }
                else
                {
                    UltimoBlocco(i, array, lunghezzaBlocco, element, n);
                }
            }

        }

        private static void UltimoBlocco(int i, int[] array, int lunghezzaBlocco, int element, int n)
        {
            i = i -lunghezzaBlocco + 1;

            while (!(array[i] >= element || i == n - 1))
            {
                i ++;
            }

            if (array[i] == element)
            {
                Console.WriteLine($"Elemento trovato in posizione {i}");
            }
            else
            {
                Console.WriteLine("Elemento non trovato");
            }
        }

        private static void EsaminaBlocco(int[] array, int i, int lunghezzaBlocco, bool trovato, int element, bool esci)
        {
            int j = i - lunghezzaBlocco + 1;

            while (!(array[j] >= element || j == i - 1))
            {
                j ++;
            }

            if (array[j] == element)
            {
                trovato = true;
                i = j;
            }
            else
            {
                esci = true;
            }
        }

        private static void CaricaArray(int[] array)
        {
            for (int i = ; i < array.Length; i++)
            {
                array[i] = LeggiNumero($"Inseririsci l'elemento numero {i + 1}");
            }
        }

        private static int LeggiNumero(string v, bool soloPositivi = true)
        {
            int n;
            bool isCorrect;

            do
            {
                Console.WriteLine(v);

                if (int.TryParse(Console.ReadLine(), out n))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Inserisci un valore valido");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && n < 0 && soloPositivi)
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero maggiore di zero");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return n;
        }

    }
}
