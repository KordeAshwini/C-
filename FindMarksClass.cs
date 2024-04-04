using System;

namespace FindClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int per;
            Console.WriteLine("Enter Percentage : ");
            per = int.Parse(Console.ReadLine());

            if (per >= 70)
            {
                Console.WriteLine("Distinction class");
            }
            else if (per >= 60 && per < 70)
            {
                Console.WriteLine("First class");
            }
            else if (per >= 50 && per < 60)
            {
                Console.WriteLine("Second class");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Pass class");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
