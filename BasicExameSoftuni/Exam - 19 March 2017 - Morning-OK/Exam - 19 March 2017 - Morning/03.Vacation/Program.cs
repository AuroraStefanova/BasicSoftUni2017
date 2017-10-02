using System;


namespace _03.Vacation
{
    class Program
    {
        static void Main()
        {
            double mony = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double sum = 0;
            if(mony  <= 1000)// Camp
            {
                if(season == "Summer")//Alaska 65%
                {
                    sum = (mony / 100) * 65;
                    Console.WriteLine($"Alaska - Camp - {sum:F2}");
                }
                else if(season == "Winter")//Morocco 45%
                {
                    sum = (mony / 100) * 45;
                    Console.WriteLine($" Morocco - Camp - {sum:F2}");
                }
            }
            else if((mony > 1000)&&(mony <= 3000))// Hut
            {
                if (season == "Summer")//Alaska 80 %
                {
                    sum = (mony / 100) * 80;
                    Console.WriteLine($"Alaska - Hut - {sum:F2}");
                }
                else if (season == "Winter")//Morocco 60%
                {
                    sum = (mony / 100) * 60;
                    Console.WriteLine($" Morocco - Hut - {sum:F2}");
                }
            }
            else if(mony > 3000)// hotel 90 %
            {
                if (season == "Summer")
                {
                    sum = (mony / 100) * 90;
                    Console.WriteLine($"Alaska - Hotel - {sum:F2}");
                }
                else if (season == "Winter")
                {
                    sum = (mony / 100) * 90;

                    Console.WriteLine($" Morocco - Hotel - {sum:F2}");
                }
            }
        }
    }
}
