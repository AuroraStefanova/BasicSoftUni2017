using System;


namespace _0._8.OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum = num + evenSum;
                }
                else
                {
                    oddSum = num + oddSum;
                }

            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes,  sum {0}", evenSum);

            }
            else
            {
                Console.WriteLine("No, diff {0}", Math.Abs(evenSum - oddSum));
            }
        }
    }
}
