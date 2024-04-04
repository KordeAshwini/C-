using System;

namespace ArrayAverage
{
    class ArrayAverageCalculator
    {
        private int[] numbers;

        public ArrayAverageCalculator(int[] arr)
        {
            numbers = arr;
        }
        public double CalculateAverage()
        {
            if (numbers.Length == 0)
            {
                return 0; // Avoid division by zero
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum = sum + num;
            }

            return (double)sum / numbers.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 10, 20, 30, 40, 50 };

            ArrayAverageCalculator calculator = new ArrayAverageCalculator(inputArray);
            double average = calculator.CalculateAverage();

            Console.WriteLine($"The average of the array elements is: {average}");
        }
    }
}
