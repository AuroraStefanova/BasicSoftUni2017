using System;

namespace _08.Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //TODO top/botom of sunglasses
 
                Console.Write(new string ('*', n * 2));
                Console.Write(new string (' ', n));
                Console.WriteLine(new string('*', n *2));

            //TODO middle of sunglasses
            for (int i = 0; i < n -2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.Write("*");
                if(i ==(n-1)/ 2 - 1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.Write("*");

                Console.WriteLine();
            }
            
            //TODO top/botom of sunglasses

               Console.Write(new string('*', n * 2));
               Console.Write(new string(' ', n));
               Console.WriteLine(new string('*', n * 2));

        }
    }
}
