using System;


namespace _01.Profit
{
    class Program
    {
        static void Main()
        {
            double dayInMonth = double.Parse(Console.ReadLine());
            double monyForDay = double.Parse(Console.ReadLine());
            double dolars = double.Parse(Console.ReadLine());

            double montPay = dayInMonth * monyForDay;
            double year = (montPay * 12) + (montPay * 2.5);
            double payments = year - ((year / 100) * 25);

            double bg = payments * dolars;
            double monY = bg / 365;
            Console.WriteLine($"{monY:F2}");
        }
    }
}
