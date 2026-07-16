using System;

namespace ConstructorOverloading
{

    class Book
    {
        string Title;
        string Author;
        double Price;
        public Book(string title)
        {
            Title = title;
            Author = "Not assigned";
            Price = 0;

        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Price = 0;
        }

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Price: " + Price);
        }




        static void Main(string[] args)
        {
            Book book1 = new Book("Sadiksha");
            Book book2 = new Book("Sadiksha", "John");
            Book book3 = new Book("Sadiksha", "John", 500);
            book1.Display();
            book2.Display();
            book3.Display();

        }
    }
}
    
