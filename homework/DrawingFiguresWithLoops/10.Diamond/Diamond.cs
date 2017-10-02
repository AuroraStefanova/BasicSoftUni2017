using System;


namespace _10.Diamond
{
    class Diamond
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int firstStar = 2 - n % 2;   
            int topRows = ((n + 1) / 2);
            int lowRows = n - topRows;


            // TODO the top of diamond
            // The top row
            int stars = (n - firstStar) / 2;
            Console.Write(new string('-', stars));
            Console.Write(new string('*', firstStar));
            Console.WriteLine(new string('-', stars));

            for (int i = 0; i < topRows - 1; i++)
            {
                int inDashes = firstStar + i * 2;//in
                int outDashes = ((n - 2 - inDashes) / 2);//out
                Console.Write(new string('-', outDashes));
                Console.Write('*');
                Console.Write(new string('-', inDashes));
                Console.WriteLine('*');
            }
            //TODO the bottom of diamond
            for (int i = 0; i < lowRows; i--)
            {
                int inDashes = firstStar + i * 2;//in
                int outDashes = ((n - 2 - inDashes) / 2);//out
                Console.Write(new string('-', outDashes));
                Console.Write('*');
                Console.Write(new string('-', inDashes));
                Console.Write('*');
                Console.WriteLine(new string('-', outDashes));
            }
            //The bottom row

            Console.Write(new string('-', stars));
            Console.Write(new string('*', firstStar));
            Console.WriteLine(new string('-', stars));
        }
    }
} 
