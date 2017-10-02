using System;


namespace _02.Toy
{
    class Program
    {
        static void Main()
        {
            double vacantion = double.Parse(Console.ReadLine());
            double brpuzzels = double.Parse(Console.ReadLine());
            double numDolyy = double.Parse(Console.ReadLine());
            double numBears = double.Parse(Console.ReadLine());
            double numMinions = double.Parse(Console.ReadLine());
            double numbus = double.Parse(Console.ReadLine());

            double pricePuzz = brpuzzels * 2.60;
            double priceDolyy = numDolyy * 3;
            double priceBears = numBears * 4.10;
            double priceMinions = numMinions * 8.20;
            double priceBuss = numbus * 2;

            double allToy = numbus + numDolyy + numMinions + numBears + brpuzzels;

            double allPrice = pricePuzz + priceDolyy + priceBears + priceMinions + priceBuss;
            double otstypka = 0;
            double sumAll = 0;
            double sum = 0;


            if(allToy >= 50)
            {
                otstypka = allPrice - ((allPrice / 100) * 25);
                sumAll = otstypka-((otstypka / 100) * 10);
                if(sumAll >= vacantion)
                {
                    sum = sumAll - vacantion;
                    Console.WriteLine($"Yes! {sum:F2} lv left.");
                }
                if(vacantion > sumAll)
                {
                    sum = vacantion - sumAll;
                    Console.WriteLine($"Not enough money! {sum:F2} lv needed.");
                }

            }
            else
            {
                sumAll = allPrice - ((allPrice / 100) * 10);

                if (sumAll >= vacantion)
                {
                    sum = sumAll - vacantion;
                    Console.WriteLine($"Yes! {sum:F2} lv left.");
                }
                if (vacantion > sumAll)
                {
                    sum = vacantion - sumAll;
                    Console.WriteLine($"Not enough money! {sum:F2} lv needed.");
                }
            }
        }
    }
}
