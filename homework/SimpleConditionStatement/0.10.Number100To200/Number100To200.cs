﻿using System;


namespace _0._10.Number100To200
{
    class Number100To200
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if(number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if((number >= 100)&&(number <= 200))
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if(number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
