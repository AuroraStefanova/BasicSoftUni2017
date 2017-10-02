using System;


namespace _0._2.smallShop
{
    class smallShop
    {
        static void Main()
        {
            string  product = Console.ReadLine();
            string city = Console.ReadLine();
            double unit = double.Parse(Console.ReadLine());
            double sum = 0;

            if(city == "Sofia")
            {
                if(product == "coffee")
                {
                    sum = (unit * 0.50);
                }
                else if(product == "water")
                {
                    sum = (unit * 0.80);
                }
                else if(product == "beer")
                {
                    sum = (unit * 1.20);
                }
                else if(product == "sweets")
                {
                    sum = (unit * 1.45);
                }
                else if(product == "peanuts")
                {
                    sum = (unit * 1.60);
                }
            }
            if(city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    sum = (unit * 0.40);
                }
                else if (product == "water")
                {
                    sum = (unit * 0.70);
                }
                else if (product == "beer")
                {
                    sum = (unit * 1.15);
                }
                else if (product == "sweets")
                {
                    sum = (unit * 1.30);
                }
                else if (product == "peanuts")
                {
                    sum = (unit * 1.50);
                }
            }
            if(city == "Varna")
            {
                if (product == "coffee")
                {
                    sum = (unit * 0.45);
                }
                else if (product == "water")
                {
                    sum = (unit * 0.70);
                }
                else if (product == "beer")
                {
                    sum = (unit * 1.10);
                }
                else if (product == "sweets")
                {
                    sum = (unit * 1.35);
                }
                else if (product == "peanuts")
                {
                    sum = (unit * 1.55);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
