using System;


namespace _11.Cinema
{
    class Cinema
    {
        static void Main()
        {
            string typeCinema = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double price = 0;

            if(typeCinema == "Premiere")
            {
                price = 12.00;
            }
            else if(typeCinema == "Normal")
            {
                price = 7.50;
            }
            else if(typeCinema == "Discount")
            {
                price = 5.00;
            }

            double result = (row * columns) * price;

            Console.WriteLine("{0:F2} leva", result);
        }
    }
}
