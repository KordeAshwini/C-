using System;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, flag = 1; ;

            Console.WriteLine("Enter a Number : ");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    flag = 0;
                    break;
                }
            }

            if(flag==1)
            {
                Console.WriteLine(n + " is a Prime Number");
            }
            else
            {
                Console.WriteLine(n + " is a not Prime Number");
            }

        }
    }
}
