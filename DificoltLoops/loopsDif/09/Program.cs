using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var sum = 0;
            do
            {
                var lastDigit = num % 10;
                sum += lastDigit;
                num /= 10;
            } while (num > 0 );
            Console.WriteLine(sum);
        }
    }
}
