using System;


namespace _05.SquareFrame
{
    class SquareFrame
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //TODO first/last row
            Console.Write("+");
            for (int firstRow = 0; firstRow < n - 2; firstRow++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            //TODO middle rows
            for (int midleRows = 0; midleRows < n-2; midleRows++)
            {


                Console.Write("|");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            //TODO first/last row
            Console.Write("+");
            for (int lastRow = 0; lastRow < n - 2; lastRow++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
