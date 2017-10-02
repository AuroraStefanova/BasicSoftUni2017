using System;


namespace _06.TwoNumbersSum
{
    class Program
    {
        static void Main()
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magickNUmber = int.Parse(Console.ReadLine());
            int caunt = 0;
            for (int i = startInterval; i >= endInterval; i--)
            {
                for (int j = startInterval; j >= endInterval; j--)
                {
                    caunt++;

                    if(i + j == magickNUmber)
                    {
                        Console.WriteLine($"Combination N:{caunt} ({i} + {j} = {magickNUmber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{caunt} combinations - neither equals {magickNUmber}");

        }
    }
}
