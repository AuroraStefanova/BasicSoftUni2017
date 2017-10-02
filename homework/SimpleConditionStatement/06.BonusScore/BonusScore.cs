using System;


namespace _06.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double bonusScore = (number * 5) / 100;
            double bonusScore1 = (number * 20) / 100;
            double bonusScore2 = (number * 10) / 100;

            if (number <= 100)//•	Ако числото е до 100 включително, бонус точките са 5.
            {
                if( number % 2 == 0)
                {
                    Console.WriteLine(number + bonusScore + 1); //•	Ако числото е по-голямо от 100, бонус точките са 20% от числото
                   // 10000000
                    else if (number % 10 == 5)
                    {
                        // var pesho = DateTime. 
                    }
                }
            } 
            
            else if( number > 100 && number <= 1000)
            {
                Console.WriteLine(number + bonusScore1 );
            }
            else if( number > 1000)
            {
                Console.WriteLine( number + bonusScore2);
            }
        }
    }
}
