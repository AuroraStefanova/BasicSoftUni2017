using System;


namespace _02.Styrofoam
{
    class Program
    {
        static void Main()
        {
            double monyHave = double.Parse(Console.ReadLine());
            double allHousePlosht = double.Parse(Console.ReadLine());
            double qwuantityWindows = double.Parse(Console.ReadLine());
            double styrofoamQuadratMiters = double.Parse(Console.ReadLine());
            double priceForPackets = double.Parse(Console.ReadLine());
            double sum = 0;
            double house = Math.Abs( (qwuantityWindows * 2.4)- allHousePlosht);// obshta plosht na kyshtata
            double houseWithFira = (house / 100) * 10 + house;
            double needSteriopor1 = Math.Ceiling((houseWithFira / styrofoamQuadratMiters));// * priceForPackets);
            double needSteriopor = needSteriopor1 * priceForPackets;
            if (needSteriopor > monyHave)
            {
                sum = needSteriopor - monyHave;
                Console.WriteLine($"Need more: {sum:F2}");
            }

            else if(needSteriopor <= monyHave)
            {
                sum = monyHave - needSteriopor;
                Console.WriteLine($"Spent: {needSteriopor:F2}");
                Console.WriteLine($"Left: {sum:F2}");

            }

        }
    }
}
