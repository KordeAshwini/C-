using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    class Employee
    {
        protected int id;
        protected String name;
        protected float sal;
        protected int age;
        public void accept()
        {
            Console.WriteLine();
            Console.Write("Enter Employee Id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            sal = float.Parse(Console.ReadLine());
            Console.Write("Enter Employee Age: ");
            age = int.Parse(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("---------------------------------------- ");
            Console.WriteLine("Employee Id: " + id);
            Console.WriteLine("Employee Name:" + name);
            Console.WriteLine("Employee Salary: " + sal);
            Console.WriteLine("Employee Age:" + age);
        }

    }
    class Developer : Employee
    {
        String favLang;
        public void accept()
        {
            base.accept();
            Console.Write("Enter Developer's Fav Language: ");
            favLang = Console.ReadLine();
        }
        public void display()
        {
            base.display();
            Console.WriteLine("Developer's Fav Language: " + favLang);
            Console.WriteLine();
        }
    }
    class Salesman : Employee
    {
        String salesArea;
        public void accept()
        {
            base.accept();
            Console.Write("Enter Salesman's Sales Area: ");
            salesArea = Console.ReadLine();
        }
        public void display()
        {
            base.display();
            Console.WriteLine("Salesman's Sales Area: " + salesArea);
            Console.WriteLine();
        }
    }
    class Manager : Employee
    {
        String dept;
        public void accept()
        {
            base.accept();
            Console.Write("Enter Manager's Department: ");
            dept = Console.ReadLine();
        }
        public void display()
        {
            base.display();
            Console.WriteLine("Manager's Department: " + dept);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hierarchical Inheritance Demo Program");
            Console.WriteLine("Enter Employee Details Below -- ");

            Developer dev = new Developer();
            dev.accept();

            Salesman sman = new Salesman();
            sman.accept();

            Manager man = new Manager();
            man.accept();

            Console.WriteLine();

            Console.WriteLine("Displaying Employee details---");
            dev.display();
            sman.display();
            man.display();

            Console.WriteLine();
        }
    }
}
    
