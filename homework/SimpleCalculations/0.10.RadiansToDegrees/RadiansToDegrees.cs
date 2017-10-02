using System;


namespace _0._10.RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main()
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = (radians * 180) / Math.PI;

            Console.WriteLine("{0:##.}", degrees);
        }
    }
}
