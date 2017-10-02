using System;


namespace _03.BikeRace
{
    class Program
    {
        static void Main()
        {
            double junior = double.Parse(Console.ReadLine());
            double old = double.Parse(Console.ReadLine());
            string trce = Console.ReadLine();
            double oldJunior = junior + old;
            double sum = 0;
            double sumPercent = 0;
            double have = 0;

            if(trce == "trail")
            {
                sum = (junior * 5.50) + (old * 7);
                have = sum - ((sum / 100) * 5);
                Console.WriteLine($"{have:F2}");
            }
            if(trce == "cross-country")
            {
                if(oldJunior >= 50)
                {
                    sum = (junior * 8) + (old * 9.50);
                    sumPercent = sum - ((sum / 100) * 25);
                    have = sumPercent - ((sumPercent / 100) * 5);
                    Console.WriteLine($"{have:F2}");
                }
                else
                {
                    sum = (junior * 8) + (old * 9.50);
                    have = sum - ((sum / 100) * 5);
                    Console.WriteLine($"{have:F2}");
                }
            }
            if(trce == "downhill")
            {
                sum = (junior * 12.25) + (old * 13.75);
                have = sum - ((sum / 100) * 5);
                Console.WriteLine($"{have:F2}");
            }
            if(trce == "road")
            {
                sum = (junior * 20) + (old * 21.50);
                have = sum - ((sum / 100) * 5);
                Console.WriteLine($"{have:F2}");
            }
        }
    }
}
