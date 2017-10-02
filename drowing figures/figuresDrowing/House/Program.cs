using System;


namespace House
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            // TODO roof
            int numOfRows = n / 2 + n % 2;
            int numStars = 0;
            if(n% 2== 0)
            {
                numStars = 2;
            }
            else
            {
                numStars = 1;
            }
            for (int row = 0; row < n; row++)
            {
                int numdashes = (n - numStars) / 2;
                Console.WriteLine();
                Console.Write(new string('*', numStars ));
                Console.WriteLine(new string('-', numdashes ));
            }
            int numof
        }
    }
}
