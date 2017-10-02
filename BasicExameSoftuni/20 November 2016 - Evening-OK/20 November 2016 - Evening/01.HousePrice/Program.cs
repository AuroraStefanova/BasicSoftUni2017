using System;


namespace _01.HousePrice
{
    class Program
    {
        static void Main()
        {
            double littleRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double priceQuadrat = double.Parse(Console.ReadLine());

            double bathroom = littleRoom / 2;
            double secondRoom = littleRoom + ((littleRoom / 100) * 10);
            double thurdRoom = secondRoom + ((secondRoom / 100) * 10);
            double apartment = littleRoom + kitchen + bathroom + secondRoom + thurdRoom;

            double allApartment = apartment + ((apartment / 100) * 5);

            double price = allApartment * priceQuadrat;

            Console.WriteLine($"{price:F2}");
        }
    }
}
