using System;


namespace _10.CheckPrime
{
    class CheckPrime
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            var prime = true;
            if (n < 2)
            {
                Console.WriteLine("Not prime");
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime == true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}

