using System;

class MyNumber
{
    private int value;

    public MyNumber(int val)
    {
        this.value = val;
    }

    // Overload the subtraction operator (-)
    public static MyNumber operator -(MyNumber num1, MyNumber num2)
    {
        return new MyNumber(num1.value - num2.value);
    }

    // Overload the increment operator (++)
    public static MyNumber operator ++(MyNumber num)
    {
        return new MyNumber(num.value + 1);
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
        MyNumber num1 = new MyNumber(10);
        MyNumber num2 = new MyNumber(5);

        // Overloaded subtraction operator (-)
        MyNumber result1 = num1 - num2;
        Console.WriteLine("Subtraction result: " + result1);

        // Overloaded increment operator (++)
        MyNumber result2 = ++num1;
        Console.WriteLine("Incremented num1: " + result2);
    }
}

