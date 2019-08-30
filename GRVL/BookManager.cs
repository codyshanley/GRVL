using System;
using System.Collections.Generic;
using System.Text;
namespace GRVL
{
    public class BookManager
    {
        public void Checkout()
        {
            Console.WriteLine("What book number do you watn to checkout");
            string answer = Console.ReadLine();
            int input = int.Parse(answer);

            BookModel book = new BookModel();

            book.booklist[input].DueDate = DateTime.Now.AddDays(14);
            book.booklist[input].Status = "Checked out";
            Console.WriteLine($"Thanks for checking out {book.booklist[input].Title}. {book.booklist[input].Title} is due back {book.booklist[input].DueDate}");
        }

        public void ReturnBook(Book book)
        {
            book.Status = "Available";
            Console.WriteLine($"Thanks for returning {book.Title}");
        }
    }
}
