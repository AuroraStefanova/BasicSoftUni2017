using System;


namespace _04.Logistics
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double three = 0;
            double eleven = 0;
            double tweve = 0;
            double caunt = 0;
            //double sum = 0;


            for (int i = 1; i <= n; i++)
            {
                double tone = double.Parse(Console.ReadLine());

                if(tone >=0 && tone <= 3)
                {
                    three += tone;
                }
                if(tone >= 4 && tone <= 11)
                {
                    eleven += tone;
                }
                if(tone >= 12)
                {
                    tweve += tone;
                }
                caunt += tone;
            }
            double sum = caunt;
            double sumePrice = (three * 200) + (eleven * 175) + (tweve * 120);
            double avarage = sumePrice / sum;
            Console.WriteLine($"{avarage:F2}");
            Console.WriteLine("{0:F2}%", (three/ sum)*100);
            Console.WriteLine("{0:F2}%", (eleven/ sum)*100);
            Console.WriteLine("{0:F2}%", (tweve / sum)*100);
        }
    }
}
