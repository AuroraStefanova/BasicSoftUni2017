using System;


namespace _04.GreaterNumber
{
    class GreaterNumber
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a >= b)
            {
                Console.WriteLine(a);
            }
            else if( a < b)
            {
                Console.WriteLine(b);
            }
        }
    }
}
