using System;


namespace _01.TrainingLab
{
    class Program
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double shir = (h * 100) - 100;
            double biora = Math.Floor(shir / 70);/// biura na  red
            double dylj =(w * 100);
            double biora2 = Math.Floor(dylj / 120);// reda

            double all = (biora * biora2) - 3;
            Console.WriteLine(all);
        }
    }
}
