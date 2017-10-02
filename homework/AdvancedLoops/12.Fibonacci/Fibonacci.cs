using System;


namespace _12.Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int firstFibonacci = 1;
            int secondFibonacci = 1;

            if(num < 2 )
            {
                Console.WriteLine(firstFibonacci);
            }
            else
            {
                for (int i = 0; i < num -1; i++)
                {
                    int next = firstFibonacci + secondFibonacci;
                    firstFibonacci = secondFibonacci;
                    secondFibonacci = next;

                }
                Console.WriteLine(secondFibonacci);
            }
        }
    }
}
