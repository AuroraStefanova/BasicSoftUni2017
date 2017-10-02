using System;


namespace _14.TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 15;
            string nool = "";

            if (minutes > 59)
            {
                hour += 1;
                minutes -= 60;
            }
            if(minutes < 10)
            {
                nool = "0";
            }
            Console.WriteLine("{0}:{1}{2}", hour % 24, nool, minutes % 60);
        }
    }
}
