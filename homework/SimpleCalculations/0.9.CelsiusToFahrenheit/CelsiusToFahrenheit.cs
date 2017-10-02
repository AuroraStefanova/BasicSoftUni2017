using System;

namespace _0._9.CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main()
        {
            double celsius = double.Parse(Console.ReadLine());//F = °C × 1,8 + 32
            double fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine("{0: ##.00}", fahrenheit);
        }
    }
}
