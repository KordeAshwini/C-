using System;

namespace StudentData
{
    class Student
    {
        public static int count = 0;
        public int roll_no;
        public String name;
        public int grade;

        public Student()
        {
            count++;
        }

        public Student(int r,String s,int g)
        {
            roll_no = r;
            name = s;
            grade = g;
            count++;
            Console.WriteLine("Object created....." + count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Program starting....");

            Student s1 = new Student(43,"Ashwini",89);
            Student s2 = new Student(42, "Anuja", 84);
            Student s3 = new Student(44, "Rohini", 87);
            Student s4 = new Student(23, "Mohini", 78);
            Student s5 = new Student(34, "Gaurav", 69);
            Student s6 = new Student(20, "Mayur", 83);
            Student s7 = new Student(37, "Sandip", 87);
            Student s8 = new Student();

            Console.WriteLine();
            Console.WriteLine("Total number of object created : "+ Student.count);
        }
    }
}
