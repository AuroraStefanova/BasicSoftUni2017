using System;


namespace _0._7.LeftАndRightSum
{
    class LeftАndRightSum
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double leftSide = 0;
            double rightSide = 0;


            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                leftSide = number + leftSide;

            }
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                rightSide = number + rightSide;

            }
            if(leftSide == rightSide)
            {
                Console.WriteLine("Yes,  sum {0}",leftSide);
            }
            else
            {
                Console.WriteLine("No, diff {0}", Math.Abs( leftSide - rightSide));
            }
        }
    }
}
