using System;


namespace _01.Titles
{
    class Program
    {
        static void Main()
        {
            double sideFlore = double.Parse(Console.ReadLine());
            double shiroPlochka = double.Parse(Console.ReadLine());
            double dyljPlochka = double.Parse(Console.ReadLine());
            double lPejka = double.Parse(Console.ReadLine());
            double dPejka = double.Parse(Console.ReadLine());

            double flore = sideFlore * sideFlore;
            double pejka = lPejka * dPejka;

            double allFlore = flore - pejka;
            double plochki = dyljPlochka * shiroPlochka;

            double need = allFlore / plochki;
            Console.WriteLine($"{need}");
            double time = need * 0.2;
            Console.WriteLine($"{time}");
        }
    }
}
