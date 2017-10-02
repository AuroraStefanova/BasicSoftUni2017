using System;


namespace _03.CarToGo
{
    class Program
    {
        static void Main()
        {
            double mony = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double sum = 0;

            if(mony <= 100)
            {
                if(season == "Summer")
                {
                    sum = (mony / 100) * 35;
                    Console.WriteLine($"Economy class");
                    Console.WriteLine($"Cabrio - {sum:F2}");
                }
                else if(season == "Winter")
                {
                    sum = (mony / 100) * 65;
                    Console.WriteLine($"Economy class");
                    Console.WriteLine($"Jeep - {sum:F2}");
                }
            }
            if((mony > 100)&&(mony <= 500))
            {
                if (season == "Summer")
                {
                    sum = (mony / 100) * 45;
                    Console.WriteLine("Compact class");
                    Console.WriteLine($"Cabrio - {sum:F2}");
                }
                else if (season == "Winter")
                {
                    sum = (mony / 100) * 80;
                    Console.WriteLine("Compact class");
                    Console.WriteLine($"Jeep - {sum:F2}");
                }
            }
            if(mony > 500)
            {
                if ((season == "Summer")|| (season == "Winter"))
                {
                    sum = mony / 100 * 90;
                    Console.WriteLine("Luxury class");
                    Console.WriteLine($"Jeep - {sum:F2}");
                }

            }
        }
    }
}
