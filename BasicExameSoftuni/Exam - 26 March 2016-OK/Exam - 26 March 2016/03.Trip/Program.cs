using System;


namespace _03.Trip
{
    class Program
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double sum = 0;
            double sumPercent = 0;

            if(money <= 100)
            {
                if(season == "summer")
                {
                    sumPercent = ((money / 100) * 30);
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {sumPercent:F2}");
                }
                if(season == "winter")
                {
                    sumPercent = (money / 100) * 70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {sumPercent:F2}");
                }
            }
            else if(money > 100 && money <= 1000)
            {
                if (season == "summer")
                {
                    sumPercent = (money / 100) * 40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {sumPercent:F2}");
                }
                if (season == "winter")
                {
                    sumPercent = (money / 100) * 80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {sumPercent:F2}");
                }
            }
            else if(money > 1000)
            {
                if (season == "summer")
                {
                    sum = (money / 100) * 90;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {sum:F2}");

                }
                if (season == "winter")
                {
                    sum = (money / 100) * 90;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {sum:F2}");

                }
            }
        }
    }
}
