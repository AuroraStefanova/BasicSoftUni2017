using System;


namespace _02.Cups
{
    class Program
    {
        static void Main()
        {
            double needCups = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double daysOnWork = double.Parse(Console.ReadLine());
            double sum = 0;

            double work = (daysOnWork * 8) * workers;// obshti `asowe za vsichki
            double cupsWorked = Math.Floor(work / 5);

            if(cupsWorked < needCups)
            {
                sum = (needCups - cupsWorked) * 4.20;
                Console.WriteLine($"Losses: {sum:F2}");
            }

            else if(cupsWorked >= needCups)
            {
                sum = (cupsWorked - needCups) * 4.20;
                Console.WriteLine($"{sum:F2} extra money");
            }

        }
    }
}
