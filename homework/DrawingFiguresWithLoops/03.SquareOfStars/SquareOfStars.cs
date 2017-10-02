using System;


namespace _03.SquareOfStars
{
    class SquareOfStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n ; i++)//rows
            {
                for (int a = 0; a < n; a++)//col
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

               
            }
        }
    }
}
