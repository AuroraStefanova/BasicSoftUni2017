using System;


namespace _06.SumTwoNumbers
{
    class Program
    {
        static void Main()
        {
            double start = double.Parse(Console.ReadLine());
            double end = double.Parse(Console.ReadLine());
            double magic = double.Parse(Console.ReadLine());
            double count = 0;
            for (double i = start; i <= end; i++)
            {
                for (double j = start; j <= end; j++)
                {
                    count++;
                    if( j + i == magic)
                    {
                        Console.WriteLine($"Combination N:{count} ({j} + {i} = {magic})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magic}");

        }
    }
}
