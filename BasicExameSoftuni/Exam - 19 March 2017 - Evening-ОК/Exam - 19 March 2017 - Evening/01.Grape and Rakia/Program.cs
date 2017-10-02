using System;


namespace _01.Grape_and_Rakia
{
    class Program
    {
        static void Main()
        {
            double grape = double.Parse(Console.ReadLine());
            double kiloFromQuadratMiters = double.Parse(Console.ReadLine());
            double fira = double.Parse(Console.ReadLine());

            double grapeKillo = (grape * kiloFromQuadratMiters) - fira;
            double forRakia = ( (grapeKillo / 100) * 45);
            double allRakia = forRakia / 7.5;
            double monyRakia = allRakia * 9.80;
            Console.WriteLine($"{monyRakia:F2}");

            double grapeForSale= Math.Abs((grapeKillo/100)*55 );
            double monyForGrape = grapeForSale * 1.50;
            Console.WriteLine($"{monyForGrape:F2}");
        }
    }
}
