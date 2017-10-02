using System;


namespace _03.MatchTickets
{
    class Program
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            string kategory = Console.ReadLine();//vip
            double group = double.Parse(Console.ReadLine());
            double VIP = 499.99;
            double normal = 249.99;
            double transport = 0;
            double allTicets = 0;
            double sum = 0;



            if (group >= 1 && group <= 4)
            {
                if(kategory == "VIP")
                {
                    transport = money - ((money / 100) * 75);//pari za transport
                    allTicets = group * VIP;
                    if(allTicets <= transport)
                    {
                        sum = transport - allTicets;
                        Console.WriteLine($"Yes! You have {sum:F2} leva left.");
                    }
                    else
                    {
                        sum = allTicets - transport;
                        Console.WriteLine($"Not enough money! You need {sum:F2} leva.");
                    }
                }
                if(kategory == "Normal")
                {
                    transport = money - ((money / 100) * 75);
                    allTicets = group * normal;
                    if (allTicets <= transport)
                    {
                        sum = transport - allTicets;
                        Console.WriteLine($"Yes! You have {sum:F2} leva left.");
                    }
                    else
                    {
                        sum = allTicets - transport;
                        Console.WriteLine($"Not enough money! You need {sum:F2} leva.");
                    }
                }
            }
            if(group >= 5 && group<= 9)
            {
                if (kategory == "VIP")
                {
                    transport = money - ((money / 100) * 60);
                    allTicets = group * VIP;
                    if (allTicets <= transport)
                    {
                        sum = transport - allTicets;
                        Console.WriteLine($"Yes! You have {sum:F2} leva left.");
                    }
                    else
                    {
                        sum = allTicets - transport;
                        Console.WriteLine($"Not enough money! You need {sum:F2} leva.");
                    }
                }
                if (kategory == "Normal")
                {
                    transport = money - ((money / 100) * 60);
                    allTicets = group * normal;
                    if (allTicets <= transport)
                    {
                        sum = transport - allTicets;
                        Console.WriteLine($"Yes! You have {sum:F2} leva left.");
                    }
                    else
                    {
                        sum = allTicets - transport;
                        Console.WriteLine($"Not enough money! You need {sum:F2} leva.");
                    }
                }
            }
            if(group >= 10 && group <= 24)
            {
                if (kategory == "VIP")
                {
                    transport = money - ((money / 100) * 50);
                    allTicets = group * VIP;
                    if (allTicets <= transport)
                    {
                        sum = transport - allTicets;
                        Console.WriteLine($"Yes! You have {sum:F2} leva left.");
                    }
                    else
                    {
                        sum = allTicets - transport;
                        Console.WriteLine($"Not enough money! You need {sum:F2} leva.");
                    }
                }
                if (kategory == "Normal")
                {
                    transport = money - ((money / 100) * 50);
                    allTicets = group * normal;
                    if (allTicets <= transport)
                    {
                        sum = transport - allTicets;
                        Console.WriteLine($"Yes! You have {sum:F2} leva left.");
                    }
                    else
                    {
                        sum = allTicets - transport;
                        Console.WriteLine($"Not enough money! You need {sum:F2} leva.");
                    }
                }
            }
            if(group >= 25 && group <= 49)
            {
                if (kategory == "VIP")
                {
                    transport = money - ((money / 100) * 40);
                    allTicets = group * VIP;
                    if (allTicets <= transport)
                    {
                        sum = transport - allTicets;
                        Console.WriteLine($"Yes! You have {sum:F2} leva left.");
                    }
                    else
                    {
                        sum = allTicets - transport;
                        Console.WriteLine($"Not enough money! You need {sum:F2} leva.");
                    }
                }
                if (kategory == "Normal")
                {
                    transport = money - ((money / 100) * 40);
                    allTicets = group * normal;
                    if (allTicets <= transport)
                    {
                        sum = transport - allTicets;
                        Console.WriteLine($"Yes! You have {sum:F2} leva left.");
                    }
                    else
                    {
                        sum = allTicets - transport;
                        Console.WriteLine($"Not enough money! You need {sum:F2} leva.");
                    }

                }
            }
            if(group >= 50)
            {
                if (kategory == "VIP")
                {
                    transport = money - ((money / 100) * 25);
                    allTicets = group * VIP;
                    if (allTicets <= transport)
                    {
                        sum = transport - allTicets;
                        Console.WriteLine($"Yes! You have {sum:F2} leva left.");
                    }
                    else
                    {
                        sum = allTicets - transport;
                        Console.WriteLine($"Not enough money! You need {sum:F2} leva.");
                    }
                }
                if (kategory == "Normal")
                {
                    transport = money - ((money / 100) * 25);
                    allTicets = group * normal;
                    if (allTicets <= transport)
                    {
                        sum = transport - allTicets;
                        Console.WriteLine($"Yes! You have {sum:F2} leva left.");
                    }
                    else
                    {
                        sum = allTicets - transport;
                        Console.WriteLine($"Not enough money! You need {sum:F2} leva.");
                    }
                }
            }
        }
    }
}
