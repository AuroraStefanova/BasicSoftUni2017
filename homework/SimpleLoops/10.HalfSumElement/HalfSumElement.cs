using System;


namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double maxNumber = Double.MinValue;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());

                sum += numbers;
                
                if(numbers > maxNumber)
                {
                    maxNumber = numbers;
                }
            }
            if (maxNumber == sum - maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", maxNumber);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs((sum - maxNumber)- maxNumber));
            }
        }
    }
}
