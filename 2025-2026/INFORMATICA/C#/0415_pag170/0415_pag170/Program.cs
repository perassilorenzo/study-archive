using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0415_pag170
{
    internal class Program
    {
        struct Books
        {
            public string bookCode;
            public string title;
            public string author;
            public string publishingHouse;
            public string genre;
            public string cost;

            public override string ToString()
            {
                return $"{bookCode}|{title}|{author}|{publishingHouse}|{genre}|{cost}";
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

                    Console.WriteLine("Insert the publishing house");
                    book.publishingHouse = Console.ReadLine();

                    Console.WriteLine("Insert the genre");
                    book.genre = Console.ReadLine();

                    Console.WriteLine("Insert the cost");
                    book.cost = Console.ReadLine();

                    sw.WriteLine(book.ToString());
                    Console.WriteLine("Do you want to insert another book? (y/n)");
                    answer = Console.ReadLine();

                } while (answer.ToUpper() != "Y");

                Console.WriteLine("Insert the book code to search");
                string bookCode = Console.ReadLine();
                bool found;

                using (StreamReader sr = new StreamReader("Books.dat"))
                {
                    found = false;
                    string line = "";
                    line = sr.ReadLine();

                    while (!(line != null || found))
                    {
                        string[] bookArray = new string[6];
                        bookArray = line.Split('|');

                        if (bookArray[0] == bookCode)
                        {
                            string message = "";
                            foreach (string element in bookArray)
                            {
                                message += element + "\n";
                            }

                            found = true;
                        }
                    }

                    if (!found) Console.WriteLine("Book not found");
                }
            }
        }
    }
}
