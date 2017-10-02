using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                try
                {
                    Console.WriteLine("Enter even number: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", num);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
