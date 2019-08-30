using System;
using System.Collections.Generic;
namespace GRVL
{
    public class BookModel
    {
        public List<Book> booklist = new List<Book>();

        public BookModel()
        {
            booklist.Add(new Book("Harry Potter the Sorcerer's Stone", "JK Rowling", "Available"));
            booklist.Add(new Book("The Great Gastby", "F. Scott Fitzgerald", "Available"));
            booklist.Add(new Book("To Kill a Mockingbird", "Harper Lee", "Available"));
            booklist.Add(new Book("1984", "George Orwell", "Available"));
            booklist.Add(new Book("The Catcher In the Rye", "J.D. Salinger", "Available"));
            booklist.Add(new Book("The Hobbit", "J.R.R. Tolkien", "Available"));
            booklist.Add(new Book("Ulysses", "Leo Tolstoy", "Available"));
            booklist.Add(new Book("Hamlet", "William Shakespeare", "Available"));
            booklist.Add(new Book("Lolita", "Vladimir Nabokov", "Available"));
            booklist.Add(new Book("The Odyssey", "Homer", "Available"));
            booklist.Add(new Book("The Adventures fo Huckleberry Finn", "Mark Twain", "Available"));
            booklist.Add(new Book("Alice In Wonderland", "Lewis Carroll", "Available"));
            booklist.Add(new Book("Moby Dick", "Herman Melville", "Available"));
            booklist.Add(new Book("War and Peace", "Leo Tolstoy", "Available"));
            booklist.Add(new Book("One Hundreds Years of Solitude", "Garbriel Garcia Marquez", "Available"));
        }
    }
}
