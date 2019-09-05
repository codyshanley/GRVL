using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GRVL
{
    public class BookManager
    {
        BookModel bookModel = new BookModel();
        public void Checkout()
        {
            int input = 0;
            bool cont1 = true;
            while (cont1 == true)
            {
                DisplayBookList();

                bool cont = true;
                while (cont == true)
                {
                    Console.WriteLine("\nWhat book number do you want to checkout\n");
                    string answer = Console.ReadLine();
                    try
                    {
                        input = int.Parse(answer);
                        cont = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Enter a valid input");
                    }
                }

                if (input < 0 || input > bookModel.booklist.Count)
                {
                    Console.WriteLine("Please enter a a valid book number\n");
                }
                else
                {
                    if (bookModel.booklist[input].Status == "Checked out")
                    {
                        Console.WriteLine($"Book is already checkout and will be returned on {bookModel.booklist[input].DueDate}\n");

                        bool cont2 = true;
                        while (cont2 == true)
                        {
                            Console.WriteLine("Would you like to checkout a different book? yes or no");
                            string answer2 = Console.ReadLine().ToLower();
                            if (answer2.Contains("n"))
                            {
                                cont1 = false;
                                cont2 = false;
                            }
                            else if (answer2.Contains("y"))
                            {
                                cont2 = false;
                            }
                            else
                            {
                                Console.WriteLine("Please answer yes or no.\n");
                                cont2 = false;
                            }
                        }
                    }
                    else
                    {
                        bookModel.booklist[input].DueDate = DateTime.Now.AddDays(14);
                        bookModel.booklist[input].Status = "Checked out";
                        Console.WriteLine($"Thanks for checking out {bookModel.booklist[input].Title}. {bookModel.booklist[input].Title} is due back {bookModel.booklist[input].DueDate}\n");
                        cont1 = false;
                    }
                }
            }
        }

        public void ReturnBook()
        {

            int input = 0;
            bool cont1 = true;
            while (cont1 == true)
            {
                DisplayBookList();

                bool cont = true;
                while (cont == true)
                {
                    Console.WriteLine("\nWhat book number do you want to return\n");
                    string answer = Console.ReadLine();
                    try
                    {
                        input = int.Parse(answer);
                        cont = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Enter a valid input");
                    }
                }

                if (input < 0 || input > bookModel.booklist.Count)
                {
                    Console.WriteLine("Please enter a a valid book number\n");
                }
                else
                {

                    if (bookModel.booklist[input].Status == "Available")
                    {
                        Console.WriteLine("This book does not need to be returned\n");
                        bool cont2 = true;
                        while (cont2 == true)
                        {
                            Console.WriteLine("Would you like to return a different book? yes or no\n");
                            string answer2 = Console.ReadLine().ToLower();
                            if (answer2.Contains("n"))
                            {
                                cont1 = false;
                                cont2 = false;
                            }
                            else if (answer2.Contains("y"))
                            {
                                cont2 = false;
                            }
                            else
                            {
                                Console.WriteLine("\nPlease answer yes or no.\n");
                            }
                        }
                    }
                    else if (bookModel.booklist[input].Status == "Checked out")
                    {
                        bookModel.booklist[input].Status = "Available";
                        Console.WriteLine($"Thanks for returning {bookModel.booklist[input].Title}. I hope you enjoyed your reading\n");
                        cont1 = false;
                        break;
                    }
                }
            }
        }
        public void DisplayBookList()
        {
            int i = 0;
            foreach (Book book in bookModel.booklist)
            {
                Thread.Sleep(40);
                Console.Write($"{i}. {book.Title}, {book.Author}, {book.Status}");
                if (book.Status == "Checked out")
                {
                    Console.WriteLine($", Due Back: {book.DueDate}");
                }
                else
                {
                    Console.WriteLine();
                }
                i++;
            }
        }
    }
}
