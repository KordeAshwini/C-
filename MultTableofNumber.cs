using System;

namespace TableDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i + "\n");
            }
            Console.ReadLine();
        }
    }
}
