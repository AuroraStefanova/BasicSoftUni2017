using System;


namespace _01.Fishland
{
    class Program
    {
        static void Main()
        {
            double priceSkumriq = double.Parse(Console.ReadLine());
            double PriceCaca = double.Parse(Console.ReadLine());
            double kilosPalamud = double.Parse(Console.ReadLine());
            double kilosSafrid = double.Parse(Console.ReadLine());
            double kilosMidi = double.Parse(Console.ReadLine());

            double pricePalamud = priceSkumriq + ((priceSkumriq / 100) * 60);
            double priceSafrid = PriceCaca + ((PriceCaca / 100) * 80);
            double priceMidi = kilosMidi * 7.50;
            double allSum = (pricePalamud * kilosPalamud) + (priceSafrid * kilosSafrid) + priceMidi;
            Console.WriteLine($"{allSum:F2}");

        }
    }
}
