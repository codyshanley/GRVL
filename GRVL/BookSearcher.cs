using System;
namespace GRVL
{
    public class BookSearcher
    {
        public void SearchByAuthor()
        {
            BookModel Bmod = new BookModel();

            Console.Write("Enter name of author: ");
            string authorName = Console.ReadLine();

            foreach (Book book in Bmod.booklist)
            {
                if (book.Author.ToLower().Contains(authorName.ToLower()))
                {
                    Console.WriteLine($"We found these titles matching your search");
                    Console.WriteLine($"{book.Author}\t{book.Title}\t{book.Status}\n");
                }
            }
        }

        public void SearchByTitle()
        {
            BookModel BMod = new BookModel();

            Console.Write("Enter title of book: ");
            string title = Console.ReadLine();

            foreach (Book book in BMod.booklist)
            {
                if (book.Title.Contains(title))
                {
                    Console.WriteLine($"We found these titles matching your search");
                    Console.WriteLine($"{book.Title}\t{book.Author}\t{book.Status}");
                }
            }
        }
    }
}
