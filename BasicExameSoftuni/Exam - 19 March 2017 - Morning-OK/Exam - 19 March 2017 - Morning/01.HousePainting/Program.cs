using System;


namespace _01.HousePainting
{
    class Program
    {
        static void Main()
        {
            double hightHowse = double.Parse(Console.ReadLine());//x
            double longHowse = double.Parse(Console.ReadLine());//y
            double hRoof = double.Parse(Console.ReadLine());//h pokriv

            //stranitsa 
            double bigSide = (hightHowse * longHowse) * 2;
            double windows = (1.5 * 1.5)*2;
            double bigAllSide = bigSide - windows;
            //little wall 
            double little = (hightHowse * hightHowse) * 2;
            double dore = 1.2 * 2;
            double littleSide = little - dore;
            //howse quadrats
            double allHowse = littleSide + bigAllSide;
            double greenPaynt = allHowse / 3.4;
            Console.WriteLine($"{greenPaynt:F2}");
            //roof
            double twoRactangle = (hightHowse * longHowse) * 2;
            double frontTriangle = (((hightHowse * hRoof / 2) * 2));
            double allRoof = twoRactangle + frontTriangle;
            double redpaynt = allRoof / 4.3;
            Console.WriteLine($"{redpaynt:F2}");

        }
    }
}
