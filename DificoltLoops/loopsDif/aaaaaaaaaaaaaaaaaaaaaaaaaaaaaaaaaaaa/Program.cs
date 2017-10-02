using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int firstNum = 1; firstNum <= n; firstNum++)
            {
                for (int secondNum = m; secondNum >= 1; secondNum--)
                {
                    sum += firstNum * 2 + secondNum * 3;
                }
            }
        }
    }
}
