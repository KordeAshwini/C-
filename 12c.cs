using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        bool areEqual = AreStringsEqual(str1, str2);

        if (areEqual == true)
        {
            Console.WriteLine("The two strings are equal in size and content.");
        }
        else
        {
            Console.WriteLine("The two strings are not equal in size or content.");
        }
    }

    static bool AreStringsEqual(string str1, string str2)
    {
        // Compare the lengths first
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Compare the content of the strings
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                return false;
            }
        }

        return true;
    }
}
