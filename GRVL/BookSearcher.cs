using System;
namespace GRVL
{
    public class BookSearcher
    {
        public void SearchByAuthor()
        {
            Console.Clear();
            bool cont1 = true;
            while (cont1 == true)
            {
                BookModel BMod = new BookModel();

                Console.Write("Enter the author of the book you are searching for, or type in \"quit\" to return to main menu.\n");
                string authorName = Console.ReadLine();

                bool cont2 = true;
                while (cont2 == true)
                {
                    bool cont3 = true;
                    while (cont3 == true)
                    {
                        foreach (Book book in BMod.booklist)
                        {
                            if (authorName == "" || authorName == " ")
                            {
                                Console.Clear();
                                Console.WriteLine("Please type the author of a book in.");
                                cont2 = false;
                                cont3 = false;
                            }
                            else if (book.Author.ToLower().Contains(authorName.ToLower()))
                            {
                                Console.WriteLine($"\nWe found these titles matching your search\n");
                                Console.WriteLine($"Author: {book.Author} \tTitle: {book.Title} \tStatus: {book.Status}\n");
                                cont2 = false;
                                break;
                            }
                            else
                            {
                                cont2 = false;
                                cont3 = false;
                            }
                        }
                    }
                    if (authorName == "quit")
                    {
                        Console.Clear();
                        cont1 = false;
                    }
                }
            }
        }

        public void SearchByTitle()
        {
            Console.Clear();
            bool cont1 = true;
            while (cont1 == true)
            {
                BookModel BMod = new BookModel();

                Console.Write("Enter the title of the book you are searching for, or type in \"quit\" to return to main menu.\n");
                string title = Console.ReadLine();

                bool cont2 = true;
                while (cont2 == true)
                {
                    bool cont3 = true;
                    while (cont3 == true)
                    {
                        foreach (Book book in BMod.booklist)
                        {
                            if (title == "" || title == " ")
                            {
                                Console.Clear();
                                Console.WriteLine("Please type a book title in.");
                                cont2 = false;
                                cont3 = false;
                            }
                            else if (book.Title.Contains(title))
                            {
                                Console.WriteLine($"\nWe found these titles matching your search\n");
                                Console.WriteLine($"Title: {book.Title} \tAuthor: {book.Author}\tStatus: {book.Status}\n");
                                cont2 = false;
                                break;
                            }
                            else
                            {
                                cont2 = false;
                                cont3 = false;
                            }
                        }
                    }
                    if (title == "quit")
                    {
                        Console.Clear();
                        cont1 = false;
                    }
                }
            }
        }
    }
}
