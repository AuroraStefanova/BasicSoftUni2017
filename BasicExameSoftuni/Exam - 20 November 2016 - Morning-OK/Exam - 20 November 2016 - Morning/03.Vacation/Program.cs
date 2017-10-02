using System;


namespace _03.Vacation
{
    class Program
    {
        static void Main()
        {
            double grolnPeople = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double sumPeople = grolnPeople + students;
            double forTransport = 0;
            double otstypka = 0;
            double sumForAllNights = 0;
            double comisionna = 0;
            double allSum = 0;

            

            if(transport == "train")
            {
                if(sumPeople >= 50)
                {
                    forTransport = ((grolnPeople * 24.99) + (students * 14.99))*2;
                    otstypka = forTransport / 2;
                    sumForAllNights = nights * 82.99;
                    comisionna = (otstypka + sumForAllNights) * 0.10;
                    allSum = otstypka + sumForAllNights + comisionna;
                    Console.WriteLine($"{allSum:F2}");
                }
                else
                {
                    forTransport = ((grolnPeople * 24.99) + (students * 14.99)) * 2;
                    sumForAllNights = nights * 82.99;
                    comisionna = (forTransport + sumForAllNights) * 0.10;
                    allSum = forTransport + sumForAllNights + comisionna;
                    Console.WriteLine($"{allSum:F2}");
                }

            }
            if(transport == "bus")
            {
                forTransport = ((grolnPeople * 32.50) + (students * 28.50)) * 2;
                sumForAllNights = nights * 82.99;
                comisionna = (forTransport + sumForAllNights) * 0.10;
                allSum = forTransport + sumForAllNights + comisionna;
                Console.WriteLine($"{allSum:F2}");
            }
            if(transport == "boat")
            {
                forTransport = ((grolnPeople * 42.99) + (students * 39.99)) * 2;
                sumForAllNights = nights * 82.99;
                comisionna = (forTransport + sumForAllNights) * 0.10;
                allSum = forTransport + sumForAllNights + comisionna;
                Console.WriteLine($"{allSum:F2}");
            }
            if(transport == "airplane")
            {
                forTransport = ((grolnPeople * 70) + (students * 50)) * 2;
                sumForAllNights = nights * 82.99;
                comisionna = (forTransport + sumForAllNights) * 0.10;
                allSum = forTransport + sumForAllNights + comisionna;
                Console.WriteLine($"{allSum:F2}");
            }

        }
    }
}
