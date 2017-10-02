using System;

namespace _0._5.TrapeziodArea
{
    class TrapeziodArea
    {
        static void Main()
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine((b1 + b2)*h/2);//(B1+B2)*h/2
        }
    }
}
