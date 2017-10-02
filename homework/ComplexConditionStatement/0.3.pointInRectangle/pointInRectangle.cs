using System;


namespace _0._3.pointInRectangle
{
    class pointInRectangle
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine()); //
            double y1 = double.Parse(Console.ReadLine()); //
            double x2 = double.Parse(Console.ReadLine()); //
            double y2 = double.Parse(Console.ReadLine()); //
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            //double point = 0;

            if((x >= x1)&&(x <= x2))
            {
                if((y >= y1)&&(y <= y2))
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Outside");
                }
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
