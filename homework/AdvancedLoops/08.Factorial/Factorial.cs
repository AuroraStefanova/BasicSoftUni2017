using System;


namespace _08.Factorial
{
    class Factorial
    {
        static void Main()
        {
            int factorialNum = int.Parse(Console.ReadLine());
            int result = factorialNum;

            for (int i = 1; i < factorialNum; i++)
            {
                result = result * i;
                
            }
            Console.WriteLine(result);
        }
    }
}
