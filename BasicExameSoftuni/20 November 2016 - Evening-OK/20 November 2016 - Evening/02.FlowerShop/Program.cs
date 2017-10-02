using System;


namespace _02.FlowerShop
{
    class Program
    {
        static void Main()
        {
            double magnolii = double.Parse(Console.ReadLine());
            double ziombiuli = double.Parse(Console.ReadLine());
            double rosses = double.Parse(Console.ReadLine());
            double cactus = double.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double sellse = ((magnolii * 3.25) + (ziombiuli * 4) + (rosses * 3.50) + (cactus * 8));
            double allSellse = sellse - ((sellse / 100) * 5);
            double sum = 0;

            if(allSellse >= priceGift)
            {
                sum = Math.Floor(allSellse - priceGift);
                Console.WriteLine($"She is left with {sum} leva.");
            }
            if(allSellse < priceGift)
            {
                sum = Math.Ceiling(priceGift - allSellse);
                Console.WriteLine($"She will have to borrow {sum} leva.");
            }
        }
    }
}
