using System;


namespace _06.MaxCombination
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {

                    count++;
                    if (count == max)
                    {
                        Console.Write($"<{i}-{j}>");
                        return;
                    }
                    Console.Write($"<{i}-{j}>");


                }
            }
        }
    }
}
