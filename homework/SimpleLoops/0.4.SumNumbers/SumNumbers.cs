using System;


namespace _0._4.SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < num; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
