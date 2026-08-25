using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0825_modulo5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Stampa = new Queue<string>();

            Stampa.Enqueue("First line");
            Stampa.Enqueue("Second line");
            Stampa.Enqueue("Third line");
            Stampa.Enqueue("Fourth line");

            Console.WriteLine(Stampa.Dequeue());
            Console.WriteLine(Stampa.Peek());

            Stack<string> Operazioni = new Stack<string>();

            Operazioni.Push("Aggiungi");
            Operazioni.Push("Modifica");
            Operazioni.Push("Elimina");

            Console.WriteLine(Operazioni.Peek());
            Console.WriteLine(Operazioni.Pop());
            Console.WriteLine(Operazioni.Peek());
        }
    }
}
