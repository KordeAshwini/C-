using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter something: ");
        string userInput = Console.ReadLine();

        // Try to parse the input as different types and identify its type
        if (int.TryParse(userInput, out int intValue))
        {
            Console.WriteLine("Input is of type: int");
        }
        else if (double.TryParse(userInput, out double doubleValue))
        {
            Console.WriteLine("Input is of type: double");
        }
        else if (bool.TryParse(userInput, out bool boolValue))
        {
            Console.WriteLine("Input is of type: bool");
        }
        else
        {
            Console.WriteLine("Input is of type: string");
        }

        Console.ReadLine(); // Keep the console window open
    }
}
