using System;


namespace _02.Company
{
    class Program
    {
        static void Main()
        {
            double needHowers = double.Parse(Console.ReadLine());
            double dayshave = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double haveDays = dayshave - ((dayshave / 100) * 10);
            double haveHowers = (haveDays * 8) ;
            double olvertime = workers * (2 * dayshave);
            double all = Math.Floor(haveHowers + olvertime);
            double sum = 0;


            if(all < needHowers)
            {
                sum = needHowers - all;
                Console.WriteLine($"Not enough time!{sum} hours needed.");
            }
            if(all >= needHowers)
            {
                sum = all - needHowers;
                Console.WriteLine($"Yes!{sum} hours left.");
            }
        }
    }
}
