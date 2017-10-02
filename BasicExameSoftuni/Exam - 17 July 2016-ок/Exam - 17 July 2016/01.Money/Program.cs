using System;

namespace _01.Money
{
    class Program
    {
        static void Main()
        {
            double quantiBitcoin = double.Parse(Console.ReadLine());
            double chinIoan = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());

            double BitcointInLv = quantiBitcoin * 1168;
            double ioanInDolars = chinIoan * 0.15;
            double levIoan = ioanInDolars * 1.76;

            double sumInLv = (BitcointInLv + levIoan) / 1.95;

            double comisionna = (sumInLv / 100) * comision;

            double all = sumInLv - comisionna;

            Console.WriteLine($"{all}");
        }
    }
}
