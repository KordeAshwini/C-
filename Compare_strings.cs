using System;

namespace slip12cCompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1, s2;

            Console.WriteLine("Enter String 1");
            s1 = Console.ReadLine();

            Console.WriteLine("Enter String 2");
            s2 = Console.ReadLine();


            if (s1.Length == s2.Length)
            {
                if (s1.Equals(s2))
                {
                    Console.WriteLine("Strings are of equal in size and are same");
                }
            }
            else
            {
                Console.WriteLine("Strings are not of the same length and not equal");
            }
        }
    }
}
