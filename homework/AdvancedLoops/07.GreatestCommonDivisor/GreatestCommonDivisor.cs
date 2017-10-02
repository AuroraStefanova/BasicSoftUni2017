using System;

namespace _07.GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while((b != 0))
            {
                int c = b;
                b = a % b;
                a = c;
            }
            Console.WriteLine(a);
        }
    }
}
