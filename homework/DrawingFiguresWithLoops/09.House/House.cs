using System;
namespace _09.House
{
    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int firstStars = 1;
            if(n % 2 == 0)
            {
                firstStars = 2;
            }
            //TODO roof
            for (int i = 0; i < (n + 1)/ 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (n - firstStars) / 2),
                     new string('*', firstStars));
                firstStars += 2;
            }
            // TODO body of house
            for (int i = 0; i < n /2; i++) 
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
                
            }
        }
    }
}
