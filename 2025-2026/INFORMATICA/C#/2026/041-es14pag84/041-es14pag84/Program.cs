using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_es14pag84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //copiare in un vettore Pari e in un vettore Dispari rispettivemente gli elementi pari e quelli dispari presenti in un vettore di interi A di lunghezza n

            int n = LeggiNumero("Inserisci la lunghezza del vettore");

            int[] A = new int[n];
            int[] Pari = new int[n];
            int[] Dispari = new int[n];

            A = CaricaVettore(n);

            Pari = NumeriPari(A, n);
            Dispari = NumeriDispari(A, n);

            ScriviVettore(Pari);
            Console.WriteLine("");
            ScriviVettore(Dispari);
        }

        private static int[] CaricaVettore(int n)
        {
            int[] array = new int[n];

            for(int i = 0;  i < n; i++)
            {
                array[i] = LeggiNumero($"Inserire l'elemento numero {i + 1} del vettore", false);
            }
            return array;
        }

        private static void ScriviVettore(int[] array)
        {

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            } 
        }

        private static int[] NumeriDispari(int[] a, int n)
        {
            int j = 0;
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    array[j] = a[i];
                    j++;
                }
            }
            Array.Resize(ref array, j);
            return array;
        }

        private static int[] NumeriPari(int[] a, int n)
        {
            int j = 0;
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    array[j] = a[i];
                    j++;
                }
            }
            Array.Resize(ref array, j);
            return array;
        }

        private static int LeggiNumero(string v, bool soloPositivi = true)
        {
            bool isCorrect;
            int n;

            do
            {
                Console.WriteLine(v);
                if(int.TryParse(Console.ReadLine(), out n))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un valore valido");
                    Console.ReadKey();
                    Console.Clear();
                }
                if(isCorrect && soloPositivi && n <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere maggiore di 0");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return n;
        }
    }
}
