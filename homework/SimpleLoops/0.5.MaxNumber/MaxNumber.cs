using System;


namespace _0._5.MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = Int32.MinValue;

            for( int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if(maxNumber < num)
                {
                    maxNumber = num;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}/*
-1000
-2000
-3000
-4000
-5000*/