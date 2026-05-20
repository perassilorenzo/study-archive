using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = CaricaArray();
            int[] array = {1523, 4521, 7894, 2341, 8765, 3456, 9012, 6543, 1234, 5678, 3210, 7650, 4320, 8901, 2109, 6789, 3987, 7123, 5432, 9876};
            int[] arrayOrdinato = OrdinaArray(array);

            int isbn;


            do
            {
                Console.WriteLine("=== GESTIONE BIBLIOTECA DIGITALE ===\n");

                isbn = LeggiNumero("Inserire l'ISBN da cercare (0 per uscire):");

                if (isbn != 0)
                {
                    Console.WriteLine("\n--- RISULTATI RICERCA ---\n");

                    RicercaSequenziale(array, isbn, out int confrontiSeq);
                    Console.WriteLine();

                    RicercaDicotomica(arrayOrdinato, isbn, out int confrontiDic);
                    Console.WriteLine();

                    Console.WriteLine("--- ANALISI EFFICIENZA ---");

                    if (confrontiSeq < confrontiDic)
                    {
                        int risparmio = confrontiDic - confrontiSeq;
                        double percentuale = risparmio * 100.0 / confrontiDic;

                        Console.WriteLine("La ricerca sequenziale è più efficiente!");
                        Console.WriteLine($"Risparmio: {risparmio} confronti ({percentuale}%)");
                    }
                    else if (confrontiDic < confrontiSeq)
                    {
                        int risparmio = confrontiSeq - confrontiDic;
                        double percentuale = risparmio * 100.0 / confrontiSeq;

                        Console.WriteLine("La ricerca dicotomica è più efficiente!");
                        Console.WriteLine($"Risparmio: {risparmio} confronti ({percentuale}%)");
                    }
                    else
                    {
                        Console.WriteLine("Le due ricerche hanno la stessa efficienza!");
                    }

                }

            } while (isbn != 0);


        }

        private static void RicercaDicotomica(int[] array, int isbn, out int confronti)
        {
            int inizio = 0;
            int fine = array.Length - 1;
            confronti = 0;
            int pos = -1;

            while (inizio <= fine && pos == -1)
            {
                int medio = (inizio + fine) / 2;
                confronti++;

                if (array[medio] == isbn)
                {
                    pos = medio;
                }
                else if (isbn < array[medio])
                {
                    fine = medio - 1;
                }
                else
                {
                    inizio = medio + 1;
                }
            }

            Console.WriteLine("2) RICERCA DICOTOMICA:");

            if (pos != -1)
            {
                Console.WriteLine($"   Libro trovato nella posizione {pos}");
                Console.WriteLine($"   Confronti effettuati: {confronti}");
            }
            else
            {
                Console.WriteLine("   Libro non trovato");
                Console.WriteLine($"   Confronti effettuati: {confronti}");
            }
        }

        private static void RicercaSequenziale(int[] array, int isbn, out int confronti)
        {
            int i = 0;
            confronti = 0;

            while (i < array.Length && isbn != array[i])
            {
                confronti++;
                i++;
            }

            if (i < array.Length)
            {
                confronti++;
                Console.WriteLine("1) RICERCA SEQUENZIALE:");
                Console.WriteLine($"   Libro trovato nella posizione {i}");
                Console.WriteLine($"   Confronti effettuati: {confronti}");
            }
            else
            {
                Console.WriteLine("1) RICERCA SEQUENZIALE:");
                Console.WriteLine("   Libro non trovato");
                Console.WriteLine($"   Confronti effettuati: {confronti}");
            }
        }

        private static int[] OrdinaArray(int[] array)
        {
            int[] ordinato = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                ordinato[i] = array[i];
            }

            for (int i = 0; i < ordinato.Length - 1; i++)
            {
                for (int j = i + 1; j < ordinato.Length; j++)
                {
                    if (ordinato[i] > ordinato[j])
                    {
                        int temp = ordinato[i];
                        ordinato[i] = ordinato[j];
                        ordinato[j] = temp;
                    }
                }
            }

            return ordinato;
        }

        private static int[] CaricaArray()
        {
            int[] array = new int[20];

            for (int i = 0; i < 20 ; i++)
            {
                array[i] = LeggiNumero($"Inserisci l'elemento numero {i + 1}");
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
