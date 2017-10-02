using System;

namespace _09.SumDigits
{
    class SumDigits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            int sum = 0;
            //do
            //{
            //    sum = sum + (number % 10);// za poluchavane na poslednoto chislo
            //    number = number / 10;//za iztriwane na poslednoto chislo
            //} while (number > 0);
            //Console.WriteLine( "{0}", sum);
            for (int i = 0; i < 10; i++)
            {

               sum = sum + (number % 10);
               number = number / 10;
                if (number < 0)
                {
                    break;
                }
            }
           Console.WriteLine(sum);
        }
    }
}
