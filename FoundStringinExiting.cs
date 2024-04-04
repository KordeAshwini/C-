using System;

namespace FoundString
{

    public class SearchString
    {
        private  String s1;
        int i = 0;
        bool bflag = false;
		
        public SearchString(string s)
        {
            this.s1 = s;
        }
		
        public bool Searchstr(String s2)
        {
            if (s1.Length < s2.Length)
            {
                return false;
            }

            for (i = 1; i <= s1.Length; i++)
            {
                if(s1.Contains(s2))
                {
                    bflag = true;
                    break;
                }
            }
            return bflag;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String s = "MY Name is Ashwini";
            SearchString sobj = new SearchString(s);

            Console.Write("Enter the word that you want to search : ");
            String str = Console.ReadLine();

            bool bret = sobj.Searchstr(str);

            if (bret == true)
            {
                Console.WriteLine("String found!!");
            }
            else
            {
                Console.WriteLine("String not found!!");
            }
            Console.ReadKey();

       }
    }
}

