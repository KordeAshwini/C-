using System;

class ArrayAverageCalculator
{
    public double CalculateAverage(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("The array is empty or null.");
        }

        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }

        return (double)sum / arr.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 10, 15, 20, 25 };

        ArrayAverageCalculator calculator = new ArrayAverageCalculator();
        double average = calculator.CalculateAverage(numbers);

        Console.WriteLine("The average of the array elements is: " + average);
    }
}
