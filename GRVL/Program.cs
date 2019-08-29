using System;

namespace GRVL
{
    class Program
    {
        static void Main(string[] args)
        {
            BookSearcher bs = new BookSearcher();
            BookModel bm = new BookModel();

            while (true)
            {
                Console.WriteLine("Welcome to the Grand Rapids Virtual Library!");
                Console.WriteLine("What would you like to do? (Please enter a number)\n");
                Console.WriteLine("1. Display book list");
                Console.WriteLine("2. Search by title");
                Console.WriteLine("3. Search by author");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    foreach (Book book in bm.booklist)
                    {
                        Console.WriteLine($"\n{book.Title}\t{book.Author}\n{book.Status}");
                    }
                }
                else if (choice == "2")
                {
                    bs.SearchByTitle();
                }
                else if (choice == "3")
                {
                    bs.SearchByAuthor();
                }
                else
                {
                    Console.WriteLine("Please enter a valid response");
                }
            }
        }
    }
}
