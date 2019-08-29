using System;
namespace GRVL
{
    public class BookModel
    {
        public List<Book> books = new List<Book>();
        public BookModel()
        {

                  
            books.Add(new Book("Harry Potter the Sorcerer's Stone", "JK Rowling", "Available"));
             books.Add(new Book("The Great Gastby", "F. Scott Fitzgerald", "Available"));
             books.Add(new Book("To Kill a Mockingbird", "Harper Lee", "Available"));
            books.Add(new Book("1984", "George Orwell", "Available"));
            books.Add(new Book("The Catcher In the Rye", "J.D. Salinger", "Available"));
            books.Add(new Book("The Hobbit", "J.R.R. Tolkien", "Available"));
            books.Add( new Book("Ulysses", "Leo Tolstoy", "Available"));
            books.Add(new Book("Hamlet", "William Shakespeare", "Available"));
            books.Add(new Book("Lolita", "Vladimir Nabokov", "Available"));
            books.Add(new Book("The Odyssey", "Homer", "Available"));
            books.Add(new Book("The Adventures fo Huckleberry Finn", "Mark Twain", "Available"));
            books.Add(new Book("Alice In Wonderland", "Lewis Carroll", "Available"));
            books.Add(new Book("Moby Dick", "Herman Melville", "Available"));
            books.Add(new Book("War and Peace", "Leo Tolstoy", "Available"));
            books.Add(new Book("One Hundreds Years of Solitude", "Garbriel Garcia Marquez", "Available"));

        }
    }
}
