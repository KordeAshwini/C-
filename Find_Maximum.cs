using System;

namespace FindMaximum
{
    class Maximum
    {
        int No1 = 0, No2 = 0;

        public Maximum(int n1,int n2)
        {
            No1 = n1;
            No2 = n2;
        }
        public int FindMax()
        {
            if (No1 > No2)
            {
                return No1;
            }
            else 
            {
                return No2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int No1=0, No2=0,iret=0;

            Console.WriteLine("Enter First Number : ");
            No1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            No2 = int.Parse(Console.ReadLine());

            Maximum mobj = new Maximum(No1, No2);

            iret=mobj.FindMax();

            Console.Write("Maximum Number is : " + iret);
            Console.ReadKey();
        }
    }
}
