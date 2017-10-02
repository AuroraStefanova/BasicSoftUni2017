using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //TODO top of sunglasses
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));

            //TODO sunglasses
            
            for (int row = 0; row < n-2; row++)
            {

                Console.Write("*");
                Console.Write( new string('/',(n * 2) - 2) );
                Console.Write("*");
                if (row == (n - 1) / 2 - 1 )
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*");
                Console.Write(new string('/', (n * 2) - 2));
                Console.WriteLine("*");

            }
            //TODO bottom of sunglasses
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
        }
    }
}
