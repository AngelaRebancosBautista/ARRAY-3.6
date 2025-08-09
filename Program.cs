using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] celsiusTemperatures = new float[5];

            Console.WriteLine("Enter 5 temperatures in Celsius");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Temperature {i + 1}: ");
                while (!float.TryParse(Console.ReadLine(), out celsiusTemperatures[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid temperature in Celsius.");
                    Console.Write($"Temperature {i + 1}: ");
                }
            }
            Console.WriteLine("\nTemperature Conversion and Categorization:");
            foreach (float celsius in celsiusTemperatures)
            {

                float fahrenheit = celsius * 9 / 5 + 32;

                string category;
                if (celsius < 15)
                {
                    category = "Cold";
                }
                else if (celsius >= 15 && celsius <= 30)
                {
                    category = "Warm";
                }
                else
                {
                    category = "Hot";
                }
                Console.WriteLine($"Celsius: {celsius}°C => Fahrenheit: {fahrenheit}°F - Category: {category}");
            }
        }
    }
}
    
