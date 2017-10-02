using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //TODO first line
            Console.Write("+ ");
            for (int i = 0; i < n- 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");

            //TODO middle
            for (int i = 0; i < n-2; i++)
            {


                Console.Write("| ");

                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("| ");
            }
            //TODO last line
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");


        }
    }
}
