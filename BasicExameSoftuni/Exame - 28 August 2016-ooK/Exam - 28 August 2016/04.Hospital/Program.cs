using System;


namespace _04.Hospital
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int doctors = 7;
            double treated = 0;
            double untreated = 0;

            for (int i = 1; i <= n; i++)
            {
                int pacient = int.Parse(Console.ReadLine());

                if((i % 3 == 0)&&(treated < untreated))
                {
                    doctors++;
                }
                if(pacient > doctors)
                {
                    treated += doctors;
                    untreated += pacient - doctors;
                }
                else if(pacient <= doctors)
                {
                    treated += pacient;
                }
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");

        }
    }
}
