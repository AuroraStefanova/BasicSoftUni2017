using System;

namespace _02.WorkHours
{
    class Program
    {
        static void Main()
        {
            double neededHours = double.Parse(Console.ReadLine());

            double workers = double.Parse(Console.ReadLine());
            double workDays = double.Parse(Console.ReadLine());
            double sum = 0;
            double overtime = 0;

            double workingHours = (workDays * 8) * workers;

            if(workingHours > neededHours)
            {
                sum = workingHours - neededHours;
                Console.WriteLine($"{sum} hours left");

            }
            if(workingHours <= neededHours)
            {

                sum = neededHours - workingHours;
                overtime = sum * workDays;
                Console.WriteLine($"{sum} overtime");
                Console.WriteLine($"Penalties: {overtime}");
            }
        }
    }
}
