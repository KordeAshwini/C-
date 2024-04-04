using System;

// Define the Book structure
struct Book
{
    public string Title;
    public string Author;
    public string Publisher;
    public double Price;
}

class Program
{
    static void Main()
    {
        // Create two Book objects and initialize their values
        Book book1;
        book1.Title = "The Catcher in the Rye";
        book1.Author = "J.D. Salinger";
        book1.Publisher = "Little, Brown and Company";
        book1.Price = 10.99;

        Book book2;
        book2.Title = "To Kill a Mockingbird";
        book2.Author = "Harper Lee";
        book2.Publisher = "HarperCollins";
        book2.Price = 12.95;

        // Print the details of the first book
        Console.WriteLine("Book 1 Details:");
        Console.WriteLine("Title: " + book1.Title);
        Console.WriteLine("Author: " + book1.Author);
        Console.WriteLine("Publisher: " + book1.Publisher);
        Console.WriteLine("Price: $" + book1.Price);

        // Print the details of the second book
        Console.WriteLine("\nBook 2 Details:");
        Console.WriteLine("Title: " + book2.Title);
        Console.WriteLine("Author: " + book2.Author);
        Console.WriteLine("Publisher: " + book2.Publisher);
        Console.WriteLine("Price: $" + book2.Price);

        Console.ReadLine(); // Keep the console window open
    }
}
