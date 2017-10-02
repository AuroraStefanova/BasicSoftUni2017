using System;


namespace _0._7._2DRectangleArea
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double areaA = 0;
            double areaB = 0;



            if( x1 > x2)
            {
                 areaA = (x1 - x2);
            }
            else if( x1 < x2)
            {
                 areaA = (x2 - x1);
            }
            if (y1 > y2)
            {
                 areaB = (y1 - y2);
            }
            else if(y1 < y2)
            {
                 areaB = (y2 - y1);
            }

            double peremeter = (2 * areaA + 2 * areaB);
            double area = (areaA * areaB);

            Console.WriteLine(area);
            Console.WriteLine(peremeter);
        }
    }
}
