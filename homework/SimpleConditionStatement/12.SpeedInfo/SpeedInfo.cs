using System;


namespace _12.SpeedInfo
{
    class SpeedInfo
    {
        static void Main()
        {
            double speed = double.Parse(Console.ReadLine());

            if(speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if((speed > 10) && (speed <= 50))//10 to 50
            {
                Console.WriteLine("average");
            }
            else if((speed > 50)&&(speed <= 150))// 50 to 150
            {
                Console.WriteLine("fast");
            }
            else if((speed > 150)&&(speed <= 1000))//150 to 1000
            {
                Console.WriteLine("ultra fast");
            }
            else if(speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
