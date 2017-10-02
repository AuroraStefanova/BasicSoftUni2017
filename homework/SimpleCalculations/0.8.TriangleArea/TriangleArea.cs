using System;

namespace _0._8.TriangleArea
{
    class TriangleArea
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = a * h / 2;

            Console.WriteLine("Triangle Area = {0: ##.00}", area);
        }
    }
}
