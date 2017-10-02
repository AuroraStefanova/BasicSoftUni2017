using System;


namespace _07.SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            int firstScore = int.Parse(Console.ReadLine());
            int secondScore = int.Parse(Console.ReadLine());
            int thurdScore = int.Parse(Console.ReadLine());
            int sumSeconds = firstScore + secondScore + thurdScore;
            int minutes = sumSeconds  / 60;
            int second = sumSeconds % 60;

            if(second < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, second);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, second);
            }
            
           // Console.WriteLine("{0:##.}:{1:00.}", minutes, second);
        }
    }
}
