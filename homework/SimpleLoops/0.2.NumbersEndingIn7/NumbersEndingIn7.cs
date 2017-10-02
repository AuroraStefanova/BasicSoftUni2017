using System;


namespace _0._2.NumbersEndingIn7
{
    class NumbersEndingIn7
    {
        static void Main()
        {
            for (int i = 1; i <= 1000 ; i++)
            {
                if(i % 100 == 87)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
