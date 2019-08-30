using System;
using System.Threading;

namespace GRVL
{
    class Program
    {
        static void Main(string[] args)
        {
            BookSearcher bs = new BookSearcher();
            BookModel bm = new BookModel();

            Console.WriteLine("Welcome to the Grand Rapids Virtual Library!");

            while (true)
            {
                Console.WriteLine("What would you like to do? (Please enter a number)\n");
                Console.WriteLine("1. Display book list");
                Console.WriteLine("2. Search by title");
                Console.WriteLine("3. Search by author");
                Console.WriteLine("4. Check in book");
                Console.WriteLine("5. Check out book");
                Console.WriteLine("6. Quit\n");

                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    int i = 0;
                    foreach (Book book in bm.booklist)
                    {
                        Thread.Sleep(40);
                        Console.WriteLine($"{i}. {book.Title}, {book.Author}, {book.Status}");
                        i++;
                    }

                    Console.WriteLine();
                }
                else if (choice == "2")
                {
                    bs.SearchByTitle();
                }
                else if (choice == "3")
                {
                    bs.SearchByAuthor();
                }

                else if (choice == "4")
                {
                    //check in
                }

                else if (choice == "5")
                {
                    //checkout
                }
                else if (choice == "6")
                {
                    Console.WriteLine("Thanks for visiting the GRVL!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid response");
                }
            }
        }
    }
}
