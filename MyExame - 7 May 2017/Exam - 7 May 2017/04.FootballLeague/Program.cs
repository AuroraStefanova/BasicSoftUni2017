using System;


namespace _04.FootballLeague
{
    class Program
    {
        static void Main()
        {
            double stadion = double.Parse(Console.ReadLine());
            double allfense = double.Parse(Console.ReadLine());

            double caunt = 0;
            double a = 0;
            double b = 0;
            double v = 0;
            double g = 0;


            for (int i = 1; i <= allfense; i++)
            {
                string sector = Console.ReadLine();

                if(sector == "A")
                {
                    a++;
                }
                if(sector == "B")
                {
                    b++;
                }
                if(sector == "V")
                {
                    v++;
                }
                if(sector == "G")
                {
                    g++;
                }
                caunt++;
            }
            Console.WriteLine("{0:F2}%", (a / allfense) * 100);
            Console.WriteLine("{0:F2}%", (b / allfense) * 100);
            Console.WriteLine("{0:F2}%", (v / allfense) * 100);
            Console.WriteLine("{0:F2}%", (g / allfense) * 100);

            Console.WriteLine("{0:f2}%", (allfense / stadion) * 100);

        }
    }
}
