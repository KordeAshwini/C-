using System;

namespace CheckPerfect
{
    class Number
    {
        private int No;

        public Number(int n)
        {
            No = n;
        }

       public int SumFactors()
        {
            int i = 0;
            int isum = 0;

            for (i = 1; i <=(No / 2); i++)
            {
                if ((No % i) == 0)
                {
                    isum = isum + i;
                }
            }
            return isum;
        }

        public bool CheckPerfect()
        {
            int iret = SumFactors();

            if (iret == No)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(String[] arg)
        {
            Console.WriteLine("Enter the Number : ");
            int ivalue = int.Parse(Console.ReadLine());

            Number nobj = new Number(ivalue);

            bool bret = false;
            bret = nobj.CheckPerfect();

            if (bret == true)
            {
                Console.WriteLine(ivalue + " is Perfect Number");
            }
            else
            {
                Console.WriteLine(ivalue + " is not Perfect Number");   
            }
        }
    }
}
