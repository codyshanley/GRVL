using System;
using System.Collections.Generic;
using System.Text;

namespace GRVL
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Status { get; set; }
        public DateTime DueDate = DateTime.Now;

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
    }
}
