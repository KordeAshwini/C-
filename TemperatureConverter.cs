using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            float Farenheit,temp;

            Console.WriteLine("Enter temperature in celcius : ");
            temp = int.Parse(Console.ReadLine());

            Console.WriteLine("Temperature in Celcius is : " + temp + " C");
             
            Farenheit = (float)(temp*1.8) + 32;

            Console.WriteLine("Temperature in Farenheit is : " + Farenheit + " F");
            Console.ReadKey();
        }
    }
}
