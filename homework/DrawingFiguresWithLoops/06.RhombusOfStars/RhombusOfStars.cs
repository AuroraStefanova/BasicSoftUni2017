using System;


namespace _06.RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //TODO up side of romb
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));

                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //TODO down side of romb
            for (int i = n - 1; i > 0 ; i--)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
