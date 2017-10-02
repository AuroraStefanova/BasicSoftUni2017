using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var currentNum = 1;
            int row = 1;


            while (currentNum <= num)
            {
                for (int i = 0; i < row; i++)
                {
                    if (currentNum > num)
                    {
                        break;
                    }
                    Console.WriteLine(currentNum + " ");
                    currentNum++;
                }

                row++;
                Console.WriteLine();
            }
        }
    }
}
