using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.obraten
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i+= 2)
            {
                int current = Math.Pow(2, i);
                Console.WriteLine(current);

            }
        }
    }
}
