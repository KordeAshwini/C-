using System;

namespace ConsoleApp10
{
    class Shape
    {
        protected int width, height;
        protected double radius;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public Shape(double a = 0)
        {
            radius = a;
        }
        public virtual int area()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }
        public virtual double area1()
        {
            Console.WriteLine("Parent class area :");
            return 0.0;
        }
    }
   
    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Parameters for reactangle were {0} and {1}", width, height);
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }
    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int area()
        {
            Console.WriteLine("Parameters for the traingle were {0}, and {1}", width, height);
            Console.WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }
    class Circle : Shape
    {
        public Circle(double a) : base(a)
        {
        }
        public override double area1()
        {
            Console.WriteLine("Parameter for the circle was {0}", radius);
            Console.WriteLine("Circle class area :");
            return 3.14 * radius * radius;
        }
    }

    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
    class Caller1
    {
        public void CallArea1(Shape sh)
        {
            double a;
            a = sh.area1();
            Console.WriteLine("Area: {0}", a);
        }
    }
    
    class Tester
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Caller1 d = new Caller1();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);
            Circle cir = new Circle(5.0);

            c.CallArea(r);
            c.CallArea(t);
            d.CallArea1(cir);
            Console.ReadKey();
        }
    }

}


