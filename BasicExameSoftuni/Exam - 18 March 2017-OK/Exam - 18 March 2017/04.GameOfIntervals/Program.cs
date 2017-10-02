using System;


namespace _04.GameOfIntervals
{
    class Program
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            double sum = 0;
            double ZeroTo9 = 0;
            double tenTo19 = 0;
            double twentyTo29 = 0;
            double thurtyTo39 = 0;
            double fortyTo50 = 0;
            double invalid = 0;

            for (int i = 1; i <= N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if((num >= 0)&&(num <= 9))
                {
                    sum += num * 0.2;
                    ZeroTo9++;
                }
                if((num >= 10) && (num <= 19))
                {
                    sum += num * 0.3;
                    tenTo19++;
                }
                if((num >= 20)&&(num <= 29))
                {
                    sum += num * 0.4;
                    twentyTo29++;
                }
                if((num >=30)&&(num <= 39))
                {
                    sum += 50;
                    thurtyTo39++;
                }
                if((num >= 40) && (num <= 50))
                {
                    sum += 100;
                    fortyTo50++;
                }
                if ((num < 0) || (num > 50))
                {
                    sum /= 2;
                    invalid++;
                }
            }

            Console.WriteLine($"{sum:F2}");
            Console.WriteLine("From 0 to 9: {0:F2}%", (ZeroTo9 / N) * 100);
            Console.WriteLine("From 10 to 19: {0:F2}%", (tenTo19 / N) * 100);
            Console.WriteLine("From 20 to 29: {0:F2}%", (twentyTo29 / N) * 100);
            Console.WriteLine("From 30 to 39: {0:F2}%", (thurtyTo39 / N) * 100);
            Console.WriteLine("From 40 to 50: {0:F2}%", (fortyTo50 / N) * 100);
            Console.WriteLine("Invalid numbers: {0:F2}%", (invalid / N) * 100);
        }
    }
}
