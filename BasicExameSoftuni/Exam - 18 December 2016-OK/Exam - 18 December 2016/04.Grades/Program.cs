using System;


namespace _04.Grades
{
    class Program
    {
        static void Main()
        {
            double student = double.Parse(Console.ReadLine());
            double Top = 0;
            double fore = 0;
            double three = 0;
            double fail = 0;
            double caunt = 0;


            for (int i = 1; i <= student; i++)
            {
                double n = double.Parse(Console.ReadLine());

                caunt += n;
                if(n >= 5)
                {
                    Top++;
                }
                if(n >= 4 && n <= 4.99)
                {
                    fore++;
                }
                if(n >= 3 && n <= 3.99)
                {
                    three++;
                }
                if(n < 3)
                {
                    fail++;
                }
            }
            double avarage = caunt / student;
            Console.WriteLine("Top students: {0:F2}%", (Top / student) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", (fore / student) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", (three / student) * 100);
            Console.WriteLine("Fail: {0:F2}%", (fail / student) * 100);
            Console.WriteLine("Average: {0:F2}", avarage);
        }
    }
}
