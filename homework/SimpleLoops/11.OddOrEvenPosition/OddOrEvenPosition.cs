using System;

namespace _11.OddOrEvenPosition
{
    class OddOrEvenPosition
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double oddMinNum = Double.MaxValue;
            double evenMinNum = Double.MaxValue;
            double oddMaxNum = Double.MinValue;
            double evenMaxNum = Double.MinValue;
            double oddSum = 0;
            double evenSum = 0;

            if (n == 0)
            {
                Console.WriteLine("OddSum=0,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;// sum

                    if (evenMaxNum < number)
                    {
                        evenMaxNum = number;//max

                    }
                    if (evenMinNum >= number)
                    {
                        evenMinNum = number;//min

                    }
                }
                else if (i % 2 != 0)
                {
                    oddSum += number;//sum

                    if (oddMaxNum < number)
                    {
                        oddMaxNum = number;//max

                    }
                    if (oddMinNum >= number)
                    {
                        oddMinNum = number;//min

                    }
                }
            }
            if (oddSum == 0)
            {
                Console.WriteLine("OddSum=0,");
            }
            else
            {
                Console.WriteLine("OddSum={0},", oddSum);
            }
            if (oddMinNum == 0)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine("OddMin={0},", oddMinNum);
            }
            if (oddMaxNum == 0)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMax={0},", oddMaxNum);
            }
            if (evenSum == 0)
            {
                Console.WriteLine("EvenSum=0,");
            }
            else
            {
                Console.WriteLine("EvenSum={0},", evenSum);
            }
            if (evenMinNum == double.MaxValue)//new
            {
                Console.WriteLine("EvenMin=No,");
            }
            else                                                //tuka e skapaniq problem
            {                                                   //tuka e skapaniq problem
                Console.WriteLine("EvenMin={0},", evenMinNum);  //tuka e skapaniq problem
            }                                                   //tuka e skapaniq problem
            if (evenMaxNum == double.MinValue)//new
            {
                Console.WriteLine("EvenMax=No,");
            }
            else
            {
                Console.WriteLine("EvenMax={0},", evenMaxNum);
            }
        }
    }
}