using System;


namespace _03.OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int value = int.Parse(Console.ReadLine());

            if(value % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
