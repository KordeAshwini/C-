using System;

class MyNumber
{
    private int value;

    public MyNumber(int value)
    {
        this.value = value;
    }

    public static MyNumber operator +(MyNumber a, MyNumber b)
    {
        return new MyNumber(a.value + b.value);
    }

    public static MyNumber operator --(MyNumber a)
    {
        return new MyNumber(a.value - 1);
    }

    public override string ToString()
    {
        return value.ToString();
    }
}

class Program
{
    static void Main()
    {
        MyNumber num1 = new MyNumber(5);
        MyNumber num2 = new MyNumber(3);

        // Overloaded + operator to add two objects
        MyNumber result1 = num1 + num2;
        Console.WriteLine("num1 + num2 = " + result1);

        // Overloaded -- operator to decrement the value of an object
        MyNumber result2 = --num1;
        Console.WriteLine("Decrement num1 by 1: " + result2);

        Console.WriteLine("num1 after decrement: " + num1);
    }
}
