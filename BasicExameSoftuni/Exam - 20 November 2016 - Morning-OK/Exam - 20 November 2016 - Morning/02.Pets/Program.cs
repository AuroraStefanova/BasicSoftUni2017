using System;


namespace _02.Pets
{
    class Program
    {
        static void Main()
        {
            double days = double.Parse(Console.ReadLine());
            double playsedFoodKilos = double.Parse(Console.ReadLine());
            double foodForDogKilo = double.Parse(Console.ReadLine());
            double CatFoodKilos = double.Parse(Console.ReadLine());
            double turtleFoodGram = double.Parse(Console.ReadLine());
            double sum = 0;
            double needsForDog = days * foodForDogKilo;
            double needCat = days * CatFoodKilos;
            double needTurtle = (turtleFoodGram / 1000) * days;
            double allNeeds = needCat + needsForDog + needTurtle;

            if(playsedFoodKilos >= allNeeds)
            {
                sum = Math.Floor(playsedFoodKilos - allNeeds);
                Console.WriteLine($"{sum} kilos of food left.");
            }
            if(playsedFoodKilos < allNeeds)
            {
                sum = Math.Ceiling(allNeeds - playsedFoodKilos);
                Console.WriteLine($"{sum} more kilos of food are needed.");
            }
        }
    }
}
