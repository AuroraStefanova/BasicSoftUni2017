using System;


namespace _02.ExcellentOrNot
{
    class ExcellentOrNot
    {
        static void Main()
        {
            double result = double.Parse(Console.ReadLine());

            if( result >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
