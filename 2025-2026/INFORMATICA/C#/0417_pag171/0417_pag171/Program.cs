using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0417_pag171
{
    internal class Program
    {
        struct Books
        {
            public string bookCode;
            public string title;
            public string author;
            public string publishHouse;
            public string genre;
            public string cost;

            public override string ToString()
            {
                return $"{bookCode}|{title}|{author}|{publishHouse}|{genre}|{cost}";
            }
        }
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("Books.dat"))
            {
                Books book = new Books();
                string answer = "";

                do
                {
                    Console.WriteLine("Insert the book code");
                    book.bookCode = Console.ReadLine();

                    Console.WriteLine("Insert the title");
                    book.title = Console.ReadLine();

                    Console.WriteLine("Insert the author");
                    book.author = Console.ReadLine();

                    Console.WriteLine("Insert the publish house");
                    book.publishHouse = Console.ReadLine();

                    Console.WriteLine("Insert the genre");
                    book.genre = Console.ReadLine();

                    Console.WriteLine("Insert the cost");
                    book.cost = Console.ReadLine();

                    sw.WriteLine(book.ToString());
                    Console.WriteLine("Do you want to insert another book? (y/n)");
                    answer = Console.ReadLine();

                } while (answer.ToUpper() != "Y");

                using (StreamReader sr = new StreamReader("Books.dat"))
                {
                    Console.WriteLine("Insert the author to search");
                    string author = Console.ReadLine();
                    bool found = false;
                    string line = sr.ReadLine();

                    while (line != null || line != "")
                    {
                        string[] bookArray = line.Split('|');

                        if (bookArray[2] == author)
                        {
                            string message = "";
                            foreach (string s in bookArray)
                            {
                                message += s + "\n";
                                found = true;
                            }
                            Console.WriteLine(message + "\n");
                        }
                    }

                    if (!found) Console.WriteLine("Author not found!");
                }
            }
        }
    }
}
