using System;


namespace _01.Alcohol
{
    class Program
    {
        static void Main()
        {
            double wiskyPryse = double.Parse(Console.ReadLine());
            double beerQantity = double.Parse(Console.ReadLine());
            double wineQuantuty = double.Parse(Console.ReadLine());
            double rakiaQuant = double.Parse(Console.ReadLine());
            double wiskiQuantity = double.Parse(Console.ReadLine());

            double priceRakiq = wiskyPryse / 2;
            double priceWine = priceRakiq-((priceRakiq / 100) * 40);
            double priceBeeer = priceRakiq-((priceRakiq / 100) * 80);

            double sumRakiq = priceRakiq * rakiaQuant;
            double sumWine = priceWine * wineQuantuty;
            double sumBeer = priceBeeer * beerQantity;
            double sumWisky = wiskyPryse * wiskiQuantity;
            double all = sumBeer + sumRakiq + sumWine + sumWisky;

            Console.WriteLine($"{all:F2}");

        }
    }
}
