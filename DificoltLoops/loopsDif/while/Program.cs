using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            int couter = 1;
            while (couter<= 100)
            {
                Console.WriteLine(couter);
                couter++;
            }
        }
    }
}
