using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipeInThePool
{
    class Program
    {
        static void Main()
        {
            int pool = int.Parse(Console.ReadLine());
            int pipeA = int.Parse(Console.ReadLine());
            int pipeB = int.Parse(Console.ReadLine());
            double freeHowers = double.Parse(Console.ReadLine());

            var wotherPipeA = (pipeA * freeHowers);
            double wotherPipeB = (pipeB * freeHowers);
            double wother = wotherPipeA + wotherPipeB;

            if (pool >= wother)//The pool is [x]% full. Pipe 1: [y]%. Pipe 2: [z]%.
            {

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(wother / pool * 100),
                    Math.Truncate(wotherPipeA / wother * 100), Math.Truncate(wotherPipeB / wother * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", freeHowers, wother - pool);
            }
        }
    }
}
