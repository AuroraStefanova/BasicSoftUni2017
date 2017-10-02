using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            int validNum = int.Parse(Console.ReadLine());

            while (validNum < 0 || validNum > 100)
            {
                Console.WriteLine("invalid num Please enter a num [0,100]");
                validNum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Genius is valid");
        }
    }
}
