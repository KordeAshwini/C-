using System;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Overload the addition operator (+)
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    // Overload the subtraction operator (-)
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point point1 = new Point(5, 3);
        Point point2 = new Point(2, 1);

        // Overloaded addition operator (+)
        Point sum = point1 + point2;
        Console.WriteLine("Addition result: " + sum);

        // Overloaded subtraction operator (-)
        Point difference = point1 - point2;
        Console.WriteLine("Subtraction result: " + difference);
    }
}

