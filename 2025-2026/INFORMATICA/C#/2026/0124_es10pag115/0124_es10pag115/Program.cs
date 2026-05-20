using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0124_es10pag115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 10 pagina 115
            // verifica se gli elementi di un vettore A di lunghezza n sono tutti uguali tra loro

            int n = LeggiNumero("Inserisci la lunghezza del vettore");
            int[] A = RiempiVettore(n);

            if (Equal(A)) Console.WriteLine("Gli elementi sono tutti uguali tra loro");
            else Console.WriteLine("Gli elementi sono diversi");
        }

        private static bool Equal(int[] a)
        {
            int temp = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] != temp) return false;
            }
            return true;

        }

        private static int[] RiempiVettore(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i++) array[i] = LeggiNumero($"Inserisci l'elemento numero {i} del vettore");

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
                    Console.WriteLine("Devi inserire un valore valido");
                    Console.Clear();
                    Console.ReadKey();
                }
                if(isCorrect && soloPositivi && n < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero positivo");
                    Console.Clear();
                    Console.ReadKey();
                }

            } while (!isCorrect);
        
            return n;
        }
    }
}
