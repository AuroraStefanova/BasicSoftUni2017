using System;


namespace _04.Division
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double one = 0;
            double two = 0;
            double three = 0;

            for (int i = 1; i <= n; i++)
            {
                double division = double.Parse(Console.ReadLine());

                if(division % 2 == 0)
                {
                    one++;
                }
                if(division % 3 == 0)
                {
                    two++;
                }
                if(division % 4 == 0)
                {
                    three++;

                }
            }
            Console.WriteLine("{0:F2}%", (one / n) * 100);
            Console.WriteLine("{0:F2}%", (two / n) * 100);
            Console.WriteLine("{0:F2}%", (three / n) * 100);
        }
    }
}
