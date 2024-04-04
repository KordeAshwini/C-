using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of cities : ");
            
            int no = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter names of cities : ");
            String[] str = new String[no];

            for (int i = 0; i < no; i++)
            {
                str[i] = Console.ReadLine();
            }

            Console.WriteLine("Citie are : ");
            for (int i = 0; i < no; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.WriteLine("Cities in Ascending order");
            Array.Sort(str);

            for (int i = 0; i < no; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.WriteLine("Cities in descending order");
            Array.Reverse(str);

            for (int i = 0; i < no; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
