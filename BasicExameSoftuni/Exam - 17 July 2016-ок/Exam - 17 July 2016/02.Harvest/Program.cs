using System;


namespace _02.Harvest
{
    class Program
    {
        static void Main()
        {
            double loze = double.Parse(Console.ReadLine());
            double grapsForQuadrat = double.Parse(Console.ReadLine());
            double needWine = double.Parse(Console.ReadLine());

            double workers = double.Parse(Console.ReadLine());

            double allGraps = loze * grapsForQuadrat;
            double Wine = (allGraps / 2.5);
            double forWine = (((Wine / 100) * 40));

            double sum = 0;
            double sumWorkers = 0;


            if(forWine >= needWine)
            {
                
                Console.WriteLine($"Good harvest this year! Total wine: {forWine} liters.");
                sum = Math.Ceiling(forWine - needWine);
                sumWorkers = Math.Ceiling(sum / workers);
                Console.WriteLine($"{sum} liters left -> {sumWorkers} liters per person.");
            }
            if(needWine > forWine)
            {
                sum = Math.Floor(needWine - forWine);
                Console.WriteLine($"It will be a tough winter! More {sum} liters wine needed.");
            }
        }
    }
}
