using System;


namespace LitlleMarcet
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if(product == "coffee")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine( quantity * 0.5);
                }
                else if(city == "Plovdiv")
                {
                    Console.WriteLine(quantity * 0.45);
                }
            }
            else if(product == "beer")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(quantity * 2);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(quantity);
                }
            }
        }
    }
}
