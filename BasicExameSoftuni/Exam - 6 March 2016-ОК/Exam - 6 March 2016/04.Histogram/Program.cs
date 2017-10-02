using System;


namespace _04.Histogram
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            for (int i = 1; i <= n; i++)
            {
                int p = int.Parse(Console.ReadLine());

                if(p < 200)
                {
                    p1++;
                }
                if(p >= 200 && p <= 399)
                {
                    p2++;
                }
                if(p >= 400 && p <= 599)
                {
                    p3++;
                }
                if(p >= 600 && p <= 799)
                {
                    p4++;
                }
                if(p >= 800)
                {
                    p5++;
                }
            }
            Console.WriteLine("{0:f2}%", (p1 / n) * 100);
            Console.WriteLine("{0:f2}%", (p2 / n) * 100);
            Console.WriteLine("{0:f2}%", (p3 / n) * 100);
            Console.WriteLine("{0:f2}%", (p4 / n) * 100);
            Console.WriteLine("{0:f2}%", (p5 / n) * 100);
        }
    }
}
