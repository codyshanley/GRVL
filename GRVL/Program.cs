using System;
using System.Threading;
using System.Collections;

namespace GRVL
{
    class Program
    {
        static void Main(string[] args)
        {
            BookSearcher bs = new BookSearcher();
            BookModel bm = new BookModel();
            BookManager bman = new BookManager();

            Console.WriteLine("Welcome to the Grand Rapids Virtual Library!");

            while (true)
            {
                Console.WriteLine("What would you like to do? (Please enter a number)\n");
                Console.WriteLine("1. Display book list\n");
                Console.WriteLine("2. Search by title\n");
                Console.WriteLine("3. Search by author\n");
                Console.WriteLine("4. Checkout a book\n");
                Console.WriteLine("5. Return a book\n");
                Console.WriteLine("4. Quit\n");

                string choice = Console.ReadLine();
                Console.Clear();

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
                    bman.Checkout();
                }

                else if (choice == "5")
                {
                    bman.ReturnBook();
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
