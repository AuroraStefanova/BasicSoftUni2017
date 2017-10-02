using System;


namespace _01.Market
{
    class Program
    {
        static void Main()
        {
            double priceVagetable = double.Parse(Console.ReadLine());
            double priceFrout = double.Parse(Console.ReadLine());
            double kiloVagetables = double.Parse(Console.ReadLine());
            double kilosFrouts = double.Parse(Console.ReadLine());

            double vegetables = priceVagetable * kiloVagetables;
            double frouts = priceFrout * kilosFrouts;
            double all = (vegetables + frouts) / 1.94;

            Console.WriteLine(all);
        }
    }
}
