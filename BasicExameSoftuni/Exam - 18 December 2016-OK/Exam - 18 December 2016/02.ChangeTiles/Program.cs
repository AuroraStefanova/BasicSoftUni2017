using System;


namespace _02.ChangeTiles
{
    class Program
    {
        static void Main()
        {
            double monyHave = double.Parse(Console.ReadLine());
            double floreShiro = double.Parse(Console.ReadLine());
            double floreDyl = double.Parse(Console.ReadLine());
            double sideTitle = double.Parse(Console.ReadLine());
            double highTitles = double.Parse(Console.ReadLine());
            double priceForOne = double.Parse(Console.ReadLine());
            double paiment = double.Parse(Console.ReadLine());

            double fira = 5;
            double sum = 0;
            double allFlore = floreDyl * floreShiro;
            double onetitle = (sideTitle * highTitles)/2;
            double needs = Math.Ceiling(allFlore / onetitle + fira);

            double needMony = (needs * priceForOne) + paiment;

            if(needMony <= monyHave)
            {
                sum = monyHave - needMony;
                Console.WriteLine($"{sum:F2} lv left.");
            }
            if(needMony > monyHave)
            {
                sum = needMony - monyHave;
                Console.WriteLine($"You'll need {sum:F2} lv more.");
            }
        }
    }
}
