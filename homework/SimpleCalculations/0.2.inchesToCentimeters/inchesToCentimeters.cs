using System;


namespace _0._2.inchesToCentimeters
{
    class inchesToCentimeters
    {
        static void Main()
        {
            double inches = double.Parse(Console.ReadLine());
            double centrimeters = inches * 2.54;

            Console.WriteLine(centrimeters);
        }
    }
}
