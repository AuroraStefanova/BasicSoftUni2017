using System;


namespace _03.hotelRoom
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double sumStudio = 0;
            double sumApartment = 0;
            double sum = 0;
            double sum1 = 0;

            if(month == "May" || month == "October")
            {
                if(nights > 7 && nights <= 14)
                {
                    sumStudio = nights * 50;
                    sum = sumStudio - ((sumStudio / 100) * 5);
                    sumApartment = nights * 65;
                    Console.WriteLine($"Apartment: {sumApartment:F2} lv.");
                    Console.WriteLine($"Studio: {sum:F2} lv.");
                }
                if(nights > 14)
                {
                    sumStudio = nights * 50;
                    sum = sumStudio - ((sumStudio / 100) * 30);
                    sumApartment = nights * 65;
                    sum1 = sumApartment - ((sumApartment / 100) * 10);
                    Console.WriteLine($"Apartment: {sum1:F2} lv.");
                    Console.WriteLine($"Studio: {sum:F2} lv.");
                }
                else if(nights <= 7)
                {
                    sumStudio = nights * 50;
                    sumApartment = nights * 65;
                    Console.WriteLine($"Apartment: {sumApartment:F2} lv.");
                    Console.WriteLine($"Studio: {sumStudio:F2} lv.");
                }
            }

            if(month == "June" || month == "September")
            {
                if(nights > 14)
                {
                    sumApartment = nights * 68.70;
                    sum1 = sumApartment - ((sumApartment / 100) * 10);
                    Console.WriteLine($"Apartment: {sum1:F2} lv.");
                    sumStudio = nights * 75.20;
                    sum = sumStudio - ((sumStudio / 100) * 20);
                    Console.WriteLine($"Studio: {sum:F2} lv.");

                }
                else if(nights <= 14)
                {
                    sumApartment = nights * 68.70;
                    sumStudio = nights * 75.20;
                    Console.WriteLine($"Apartment: {sumApartment:F2} lv.");
                    Console.WriteLine($"Studio: {sumStudio:F2} lv.");

                }
            }

            if(month == "July" || month == "August")
            {
                if(nights > 14)
                {
                    sumApartment = nights * 77.00;
                    sum1 = sumApartment - ((sumApartment / 100) * 10);
                    Console.WriteLine($"Apartment: {sum1:F2} lv.");
                    sumStudio = nights * 76.00;
                    Console.WriteLine($"Studio: {sumStudio:F2} lv.");


                }
                else if(nights <= 14)
                {
                    sumApartment = nights * 77;
                    sumStudio = nights * 76;
                    Console.WriteLine($"Apartment: {sumApartment:F2} lv.");
                    Console.WriteLine($"Studio: {sumStudio:F2} lv.");

                }
            }
        }
    }
}
