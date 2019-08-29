using System;
using System.Collections.Generic;
using System.Text;

namespace GRVL
{
    class Book
    {

                    

        public Book(string title, string author, string status )
        {
            this.Title = title;
            this.Author = author;
            this.Status = status;
        }

        public Book(string title, string author, string status, DateTime dueDate)
        {
            this.Title = title;
            this.Author = author;
            this.Status = status;
            this.DueDate = dueDate;
        }


        Book book1 = new Book("Harry Potter the Sorcerer's Stone", "JK Rowling");
        Book book2 = new Book("The Great Gastby", "F. Scott Fitzgerald");
        Book book3 = new Book("To Kill a Mockingbird", "Harper Lee");
        Book book4 = new Book("1984", "George Orwell");
        Book book5 = new Book("The Catcher In the Rye", "J.D. Salinger");
        Book book6 = new Book("The Hobbit", "J.R.R. Tolkien");
        Book book7 = new Book("Ulysses", "Leo Tolstoy");
        Book book8 = new Book("Hamlet", "William Shakespeare");
        Book book9 = new Book("Lolita", "Vladimir Nabokov");
        Book book10 = new Book("The Odyssey", "Homer");
        Book book11 = new Book("The Adventures fo Huckleberry Finn", "Mark Twain");
        Book book12 = new Book("Alice In Wonderland", "Lewis Carroll");
        Book book13= new Book("Moby Dick", "Herman Melville");
        Book book14 = new Book("War and Peace", "Leo Tolstoy");
        Book book15 = new Book("One Hundreds Years of Solitude", "Garbriel Garcia Marquez");
    }

}
