using System;


namespace _04.BackToThePast
{
    class Program
    {
        static void Main()
        {
            double nasledstvo = double.Parse(Console.ReadLine());
            double year = double.Parse(Console.ReadLine());
            double ivancho = 18;
            double oldNasledstvo = nasledstvo;
            double sum = 0;


            for (int i = 1800; i <= year; i++)
            {
                
                if(i % 2 == 0)
                {
                    nasledstvo -= 12000;
                }
                else
                {
                    nasledstvo -= (12000 + (50 * ivancho));
                }
                ivancho++;
            }
            if(nasledstvo < 0)
            {
                sum = Math.Abs( nasledstvo);
                Console.WriteLine($"He will need {sum:F2} dollars to survive.");

            }
            if (nasledstvo >= 0)
            {
                
                Console.WriteLine($"Yes! He will live a carefree life and will have {nasledstvo:F2} dollars left.");
            }
        }
    }
}
