using System;
using System.Collections.Generic;                                        
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;//double sum = 0;
            double previusSum = 0;//double oldPairs = 0;
            double diff = 0;//double difference = 0;

            for (int i = 0; i < n; i++)//for (int i = 0; i < n; i++)
            {
                double firsNum = double.Parse(Console.ReadLine());
                double secondNum = double.Parse(Console.ReadLine());

                sum = firsNum + secondNum;//sum = Odd + Even;

                diff = Math.Abs(sum - previusSum);//

                previusSum = sum;//oldPairs = sum;
            }
            if (n == 1)//
            {
                Console.WriteLine("Yes, value={0}", diff);//Console.WriteLine("Yes, value={0}", difference);

            }
            else
            {
                if(diff == 0)//if (difference == 0)
                {
                    Console.WriteLine("Yes, value={0}", sum);
                }
                else
                {
                    Console.WriteLine("No, maxdiff={}", diff);
                }
            }
        }
    }
}
