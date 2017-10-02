using System;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string yearType = Console.ReadLine();
            int pHollidays = int.Parse(Console.ReadLine());
            int hWeekendsHome = int.Parse(Console.ReadLine());

            int allWeekends = 48;
            int weekends = allWeekends - hWeekendsHome;
            double totalPlay = weekends * 3.0 / 4;
            totalPlay += hWeekendsHome;
            totalPlay += pHollidays * 2.0 / 3;

            switch (yearType)
            {
                case "leap":
                    totalPlay += totalPlay * 0.15;
                    break;
                case "normal":
                    totalPlay = totalPlay;
                    break;
            }
            Console.WriteLine(Math.Floor(totalPlay));
        }
    }
}
