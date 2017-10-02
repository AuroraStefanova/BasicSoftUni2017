using System;


namespace _02.transport
{
    class Program
    {
        static void Main()
        {
            double kilometres = double.Parse(Console.ReadLine());
            string hower = Console.ReadLine();
            double sumkilo = 0;
            if( kilometres < 20)
            {
                if(hower == "day")
                {
                    sumkilo = (kilometres * 0.79) + 0.70;
                    Console.WriteLine($"{sumkilo}");
                }
                else
                {
                    sumkilo = (kilometres * 0.90) + 0.70;
                    Console.WriteLine($"{sumkilo}");
                }
            }
            if(kilometres >=20 && kilometres < 100)
            {
                sumkilo = kilometres * 0.09;
                Console.WriteLine($"{sumkilo}");
            }
            if(kilometres > 100)
            {
                sumkilo = kilometres * 0.06;
                Console.WriteLine($"{sumkilo}"); 
            }
        }
    }
}
