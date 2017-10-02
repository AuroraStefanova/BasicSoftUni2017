using System;


namespace _0._6.MinNumber
{
    class MinNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int minNum = Int32.MaxValue;

            for (int i = 1; i <= n ; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if(minNum > num)
                {
                    minNum = num;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
