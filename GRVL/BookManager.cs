using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GRVL
{
    public class BookManager
    {
        public void Checkout()
        {
            BookModel bm = new BookModel();
            int i = 0;

            foreach (Book book in bm.booklist)
            {
                Thread.Sleep(40);
                Console.WriteLine($"{i}. {book.Title}, {book.Author}, {book.Status}");
                i++;
            }

            Console.WriteLine("\nWhat book number do you want to checkout");
            string answer = Console.ReadLine();
            int input = int.Parse(answer);

            BookModel bookCheckout = new BookModel();

            bookCheckout.booklist[input].DueDate = DateTime.Now.AddDays(14);
            bookCheckout.booklist[input].Status = "Checked out";
            Console.WriteLine($"Thanks for checking out {bookCheckout.booklist[input].Title}. {bookCheckout.booklist[input].Title} is due back {bookCheckout.booklist[input].DueDate}");
        }

        public void ReturnBook()
        {
            BookModel bm = new BookModel();
            int i = 0;

            foreach (Book book in bm.booklist)
            {
                Thread.Sleep(40);
                Console.WriteLine($"{i}. {book.Title}, {book.Author}, {book.Status}");
                i++;
            }
            Console.WriteLine();

            Console.WriteLine("\nWhat book number do you want to checkout");
            string answer = Console.ReadLine();
            int input = int.Parse(answer);

            BookModel bookReturn = new BookModel();

            bookReturn.booklist[input].Status = "Available";
            Console.WriteLine($"Thanks for returning {bookReturn.booklist[input].Title}. I hope you enjoyed your reading");
        }
    }
}
