using System;

namespace slip6d
{
    class Employee
    {
        protected int eid;
        protected String ename;
        protected float sal;

        public Employee(int id, String name, float s)
        {
            eid = id;
            ename = name;
            sal = s;
        }
        public void Display()
        {
            Console.WriteLine("Employee id :" + eid);
            Console.WriteLine("Employee name :" + ename);
            Console.WriteLine("Employee salary :" + sal);
            Console.WriteLine();
        }

        public float getSalary()
        {
            return sal;
        }

    }
    class Manager : Employee
    {
        float hra;
        float ta;

        public Manager(int id, String name, float s, float h, float t) : base(id, name, s)
        {
            hra = h;
            ta = t;
            //sal = sal + hra + ta ;
        }

        public float getSalary()
        {
            return sal=sal+hra+ta;
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Employee emp1 = new Employee(101, "Suresh", 30000);
            Manager man1 = new Manager(201, "Dinesh", 45000,2000,1000);

           emp1.Display();
           man1.Display();

            Console.WriteLine("Salary of emp1 :" + emp1.getSalary());
            Console.WriteLine("Salary of man1 :" + man1.getSalary());

        }

    }

}
