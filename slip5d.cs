using System;

class MyNumber
{
    private int value;

    public MyNumber(int val)
    {
        value = val;
    }

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }

    // Overload the * operator to add two MyNumber objects
    public static MyNumber operator *(MyNumber num1, MyNumber num2)
    {
        return new MyNumber(num1.Value * num2.Value);
    }

    // Overload the ++ operator to decrement the value of MyNumber
    public static MyNumber operator ++(MyNumber num)
    {
        return new MyNumber(num.Value + 1);
    }

    // Display the value of MyNumber
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
        MyNumber num2 = new MyNumber(10);

        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        MyNumber result = num1 * num2;
        Console.WriteLine("Result of num1 * num2 = " + result);

        num1++;
        Console.WriteLine("After num1++, num1 = " + num1);
    }
}

