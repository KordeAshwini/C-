using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            float rupee,dollar;

            Console.WriteLine("Enter Currency in Rupee :");
            rupee = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Currency in Dollar :");
            dollar = float.Parse(Console.ReadLine());

            Console.WriteLine("Converting Rupee into Dollar...");
            float USD = rupee / 70;
            Console.WriteLine("Indian Rupee " + rupee + " = " + USD + " US Dollars");

            Console.WriteLine();

            Console.WriteLine("Converting Dollar into Rupee...");
            double INR = dollar * 70;
            Console.WriteLine("US Dollars " + dollar + " = " + INR + " Indian Rupee ");

            Console.ReadKey();

        }
    }
}
