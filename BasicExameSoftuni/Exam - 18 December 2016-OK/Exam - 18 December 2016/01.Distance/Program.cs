using System;


namespace _01.Distance
{
    class Program
    {
        static void Main()
        {
            double firstScore = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thurtTime = double.Parse(Console.ReadLine());


            double firstScoreFuck = firstScore * (firstTime / 60);//te towa a* b/60
            double secondScore  = ((firstScore / 100) * 10) + firstScore;//x/100*10 + x
            double secondDistance = secondScore * (secondTime / 60);
            double thurdScore = Math.Abs(((secondScore / 100) * 5)- secondScore);
            double afterDictance  = thurdScore * (thurtTime / 60);
            double all = firstScoreFuck + secondDistance + afterDictance;
            Console.WriteLine($"{all:F2}");
        }
    }
}
