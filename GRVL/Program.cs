using System;

namespace GRVL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Rapids Virtual Library!");
            Console.WriteLine("What would you like to do? (Please enter a number)\n");
            Console.WriteLine("1. Display book list");
            Console.WriteLine("2. Search by title");
            Console.WriteLine("3. Search by author");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                //display book list
            }
            else if (choice == "2")
            {
                //search by title
            }
            else if (choice == "3")
            {
                //search by author
            }
            else
            {

            }

            
        }
    }
}
