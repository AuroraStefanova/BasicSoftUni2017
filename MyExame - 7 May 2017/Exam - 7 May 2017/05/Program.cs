using System;


namespace _05
{
    class Program
    {
        static void Main()

        {

            int N = int.Parse(Console.ReadLine());
            //todo top
            for (int i = 1; i <= (2 * N)-1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('@');
                }
                
            }
            // midle
            //*...*.....*...*
            //*....* *.* *....*
            for (int i = 0; i < (2 * N) - 1; i++)
            {
                for (int i = 0; i < i; i++)//*
                {
                    Console.Write('*');
                }
                for (int i = 0; i < i + 3; i++)
                {
                    Console.Write('.');
                }
                for (int i = 0; i < (N/2)-2; i++)
                {
                    Console.Write('*');
                }

            }

            //to do bottom 2 line
            for (int i = 1; i <= (2 * N)- 1; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
            for (int i = 01; i <= (2 * N) - 1; i++)
            {
                Console.Write('*');
            }
        }
    }
}
