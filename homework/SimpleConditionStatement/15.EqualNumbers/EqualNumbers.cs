using System;


namespace _15.EqualNumbers
{
    class EqualNumbers
    {
        static void Main()
        {
            double firsNumber = double.Parse(Console.ReadLine());
            double seconNumber = double.Parse(Console.ReadLine());
            double thurdNumber = double.Parse(Console.ReadLine());

            if ((firsNumber == seconNumber) && (firsNumber == thurdNumber) && (seconNumber == thurdNumber))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
