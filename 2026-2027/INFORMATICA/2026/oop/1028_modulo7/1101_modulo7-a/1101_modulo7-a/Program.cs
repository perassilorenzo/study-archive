using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1101_modulo7_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studente> studenti = new List<Studente>();
            Dictionary<int, Studente> dizionario = new Dictionary<int, Studente>();

            int scelta;

            do
            {
                Console.WriteLine("1. Aggiungi studente");
                Console.WriteLine("2. Rimuovi studente");
                Console.WriteLine("3. Cerca studente");
                Console.WriteLine("4. Modifica studente");
                Console.WriteLine("5. Visualizza studenti");
                Console.WriteLine("0. Esci");
                Console.Write("Scelta: ");

                scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.Write("Matricola: ");
                        int matricola = int.Parse(Console.ReadLine());

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Cognome: ");
                        string cognome = Console.ReadLine();

                        Console.Write("Età: ");
                        int eta = int.Parse(Console.ReadLine());

                        if (!dizionario.ContainsKey(matricola))
                        {
                            Studente s = new Studente(matricola, nome, cognome, eta);
                            studenti.Add(s);
                            dizionario.Add(matricola, s);
                            Console.WriteLine("Studente aggiunto.");
                        }
                        else
                            Console.WriteLine("Matricola già esistente.");

                        break;

                    case 2:
                        Console.Write("Matricola: ");
                        matricola = int.Parse(Console.ReadLine());

                        if (dizionario.ContainsKey(matricola))
                        {
                            studenti.Remove(dizionario[matricola]);
                            dizionario.Remove(matricola);
                            Console.WriteLine("Studente rimosso.");
                        }
                        else
                            Console.WriteLine("Studente non trovato.");

                        break;

                    case 3:
                        Console.Write("Matricola: ");
                        matricola = int.Parse(Console.ReadLine());

                        if (dizionario.ContainsKey(matricola))
                            Console.WriteLine(dizionario[matricola]);
                        else
                            Console.WriteLine("Studente non trovato.");

                        break;

                    case 4:
                        Console.Write("Matricola: ");
                        matricola = int.Parse(Console.ReadLine());

                        if (dizionario.ContainsKey(matricola))
                        {
                            Console.Write("Nuovo nome: ");
                            nome = Console.ReadLine();

                            Console.Write("Nuovo cognome: ");
                            cognome = Console.ReadLine();

                            Console.Write("Nuova età: ");
                            eta = int.Parse(Console.ReadLine());

                            dizionario[matricola].ModificaDati(nome, cognome, eta);
                            Console.WriteLine("Studente modificato.");
                        }
                        else
                            Console.WriteLine("Studente non trovato.");

                        break;

                    case 5:
                        foreach (Studente s in studenti)
                            Console.WriteLine(s);

                        break;
                }

            } while (scelta != 0);
        }
    }
}
