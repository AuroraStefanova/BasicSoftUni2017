using System;


namespace _0._1.personalTitles
{
    class personalTitles
    {
        static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if(age < 16)
            {
                if(gender == "f")
                {
                    Console.WriteLine("Miss");
                }
                else if(gender == "m")
                {
                    Console.WriteLine("Master");
                }
            }
            if(age >= 16)
            {
                if(gender == "f")
                {
                    Console.WriteLine("Ms.");
                }
                else if(gender == "m")
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
