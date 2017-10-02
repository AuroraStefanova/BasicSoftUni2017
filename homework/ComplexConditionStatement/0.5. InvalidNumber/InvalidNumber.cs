using System;


namespace _0._5.InvalidNumber
{
    class InvalidNumber
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if((inputNumber == 0 )||(inputNumber >= 100)&&(inputNumber <= 200))
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
