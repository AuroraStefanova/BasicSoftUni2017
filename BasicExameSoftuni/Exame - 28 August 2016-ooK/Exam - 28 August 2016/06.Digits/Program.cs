using System;

namespace _06.Digits
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            int firsi = a / 100;
            int second = (a / 10) % 10;
            int thurd = a % 10;

            int row = firsi + second;
            int col = firsi + thurd;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if( a % 5 == 0)
                    {
                        a = a - firsi;
                    }
                    else if(a % 3 == 0)
                    {
                        a = a - second;
                    }
                    else
                    {
                        a = a + thurd;
                    }
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }
        }
    }
}
