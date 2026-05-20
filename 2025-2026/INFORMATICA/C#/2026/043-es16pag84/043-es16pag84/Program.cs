using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_es16pag84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dopo aver caticao un vettore di interi A di lunghezza n, cercare i tre lementi più grandi visualizzandoli in ordine decrescente, supponendo che non ci possano essere pari merito

            int n = LeggiNumero("Inserisci la lunghezza del vettore");
            int[] A = new int[n];

            A = RiempiVettore(n);

            StampaMax(A);
            
        }

        private static void StampaMax(int[] a)
        {
            int max1 = int.MinValue;
            int max2= int.MinValue;
            int max3 = int.MinValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max3)
                {
                    max3 = a[i];
                }
                else if (a[i] > max2)
                {
                    max2 = a[i];
                }
                else if(a[i] > max1)
                {
                    max1 = a[i];
                }

            }
                Console.WriteLine(max3 + " " + max2 + " " + max1);
        }

        private static int[] RiempiVettore(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = LeggiNumero($"Inserisci l'elemento numero {i+1} del vettore", false);
            }
            
            return array;
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
                    Console.WriteLine("Devi inserire un numero valido");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (soloPositivi && isCorrect && n < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero maggiore di zero");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return n;
        }
    }
}
