using System;

class MyNumber
{
    private int value;

    public MyNumber(int val)
    {
        this.value = val;
    }

    // Overload the * operator to add two MyNumber objects
    public static MyNumber operator *(MyNumber num1, MyNumber num2)
    {
        return new MyNumber(num1.value * num2.value);
    }

    // Overload the ++ operator to decrement the value of MyNumber
    public static MyNumber operator ++(MyNumber num)
    {
        return new MyNumber(num.value + 1);
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
        MyNumber num1 = new MyNumber(15);
        MyNumber num2 = new MyNumber(10);

        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        MyNumber result = num1 * num2;
        Console.WriteLine("Result of num1 * num2 = " + result);

        num1++;
        Console.WriteLine("After num1++, num1 = " + num1);
    }
}

