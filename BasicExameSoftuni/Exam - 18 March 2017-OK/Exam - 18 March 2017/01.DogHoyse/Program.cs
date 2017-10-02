using System;


namespace _01.DogHoyse
{
    class Program
    {
        static void Main()
        {
            double longHouse = double.Parse(Console.ReadLine());
            double highHouse = double.Parse(Console.ReadLine());

            double bigSide = (longHouse * (longHouse / 2)) * 2;//
            double quadrat = (longHouse / 2) * (longHouse / 2);
            double triangle = ((longHouse / 2) * (highHouse - (longHouse / 2))) / 2;
            double dore = (longHouse / 5) * (longHouse / 5);
            double backSide = quadrat + triangle;//
            double frontSide = backSide - dore;//

            double allHouse = frontSide + bigSide + backSide;
            double greenPaint = allHouse / 3;
            Console.WriteLine($"{greenPaint:F2}");
            double roof = (longHouse * (longHouse / 2)) * 2;
            double redPaint = roof / 5;
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
