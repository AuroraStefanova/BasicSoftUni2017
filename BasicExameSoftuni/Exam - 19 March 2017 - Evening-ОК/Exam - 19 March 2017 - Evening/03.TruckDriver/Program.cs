using System;


namespace _03.TruckDriver
{
    class Program
    {
        static void Main()
        {
            string season = Console.ReadLine();
            double kilometrisForMonth = double.Parse(Console.ReadLine());
            double sum = 0;
            double sumWithDanak = 0;
            if(kilometrisForMonth <= 5000)
            {

                if((season == "Spring")||(season == "Autumn"))
                {
                    sum = (kilometrisForMonth * 4) * 0.75;
                    sumWithDanak = Math.Abs((sum / 100) * 10 - sum);
                    Console.WriteLine($"{sumWithDanak:F2}");
                }
                if(season == "Summer")
                {
                    sum = (kilometrisForMonth * 4) * 0.90;
                    sumWithDanak = Math.Abs((sum / 100) * 10 - sum);
                    Console.WriteLine($"{sumWithDanak:F2}");
                }
                if(season == "Winter")
                {
                    sum = (kilometrisForMonth * 4) * 1.05;
                    sumWithDanak = Math.Abs((sum / 100) * 10 - sum);
                    Console.WriteLine($"{sumWithDanak:F2}");
                }
            }
            else if(kilometrisForMonth > 5000 && kilometrisForMonth <= 10000)
            {
                if ((season == "Spring") || (season == "Autumn"))
                {
                    sum = (kilometrisForMonth * 4) * 0.95;
                    sumWithDanak = Math.Abs((sum / 100) * 10 - sum);
                    Console.WriteLine($"{sumWithDanak:F2}");
                }
                if (season == "Summer")
                {
                    sum = (kilometrisForMonth * 4) * 1.10;
                    sumWithDanak = Math.Abs((sum / 100) * 10 - sum);
                    Console.WriteLine($"{sumWithDanak:F2}");
                }
                if (season == "Winter")
                {
                    sum = (kilometrisForMonth * 4) * 1.25;
                    sumWithDanak = Math.Abs((sum / 100) * 10 - sum);
                    Console.WriteLine($"{sumWithDanak:F2}");
                }
            }
            else if( kilometrisForMonth > 10000 && kilometrisForMonth <= 20000)
            {
                sum = (kilometrisForMonth * 4) * 1.45;
                sumWithDanak = Math.Abs((sum / 100) * 10 - sum);
                Console.WriteLine($"{sumWithDanak:F2}");
            }
        }
    }
}
