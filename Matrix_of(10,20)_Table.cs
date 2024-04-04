using System;

namespace MatrixTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,i;
            n1 = 10;
            n2 = 20;

            for (i = 1; i <= 10; i++)
            {
                Console.Write(n1 * i + "\t" + n2 * i+"\n");
            }
            Console.ReadKey();
        }
    }
}
