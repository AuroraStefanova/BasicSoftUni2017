using System;


namespace _02.TomCat
{
    class Program
    {
        static void Main()
        {
            double RestDays = double.Parse(Console.ReadLine());
            double howers = 0;
            double min = 0;
            double neeeds = 0;
            double workDay = 365 - RestDays;
            double allGaming = (workDay * 63) + (RestDays * 127);

            if (allGaming > 30000)
            {
                Console.WriteLine("Tom will run away");
                neeeds = (allGaming - 30000);
                howers = Math.Floor(neeeds / 60);
                min = neeeds % 60;
                Console.WriteLine($"{howers} hours and {min} minutes more for play");

            }

            else
            {
                Console.WriteLine("Tom sleeps well");
                neeeds = ( 30000 - allGaming);
                howers = Math.Floor(neeeds / 60);
                min = neeeds % 60;
                Console.WriteLine($"{howers} hours and {min} minutes less for play");

            }
        }
    }
}
