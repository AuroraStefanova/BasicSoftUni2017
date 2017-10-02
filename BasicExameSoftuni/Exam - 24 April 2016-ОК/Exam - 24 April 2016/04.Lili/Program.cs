using System;

namespace _04.Lili
{
    class Program
    {
        static void Main()
        {
            double liliAge = double.Parse(Console.ReadLine());
            double priceWash = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double toy = 0;
            double brother = 0;
            double bday = 0;
            double sum = 0;
            for (int i = 1; i <= liliAge; i++)
            {
                if(i % 2 == 0)
                {
                    brother++;
                    bday += i * 5;
                }
                else
                {
                    toy++;
                }
            }
            double toySell = toy * toyPrice;
            double sumFroBD = bday - brother;
            double allspandedSum = toySell + sumFroBD;
            if( allspandedSum < priceWash)
            {
                sum = priceWash - allspandedSum;
                Console.WriteLine($"No! {sum:F2}");
            }
            else
            {
                sum = allspandedSum - priceWash;
                Console.WriteLine($"Yes! {sum:F2}");
            }
        }
    }
}
