using System;

namespace _04.EvenPowersOf2
{
    class EvenPowersOf2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 0; i <= n ; i+=2)
            {
                Console.WriteLine(num);
                num = num * 4;
            }
        }
    }
}
