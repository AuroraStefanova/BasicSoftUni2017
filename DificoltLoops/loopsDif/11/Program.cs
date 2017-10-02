using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n);
            }
            catch 
            {
                Console.WriteLine("The number is not even.");
                
            }
        }
    }
}
