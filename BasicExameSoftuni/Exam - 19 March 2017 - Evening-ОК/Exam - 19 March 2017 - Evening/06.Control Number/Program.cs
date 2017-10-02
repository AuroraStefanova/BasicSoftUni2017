using System;


namespace _06.Control_Number
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int controlNUm = int.Parse(Console.ReadLine());
            int sum = 0;
            int caunt = 0;

            for (int i = 1; i <= N; i++)
            {

                for (int j = M; j >= 1; j--)
                {
                    caunt++;
                    sum +=(( i * 2) + (j * 3));
                    if(  sum >= controlNUm)
                    {
                        Console.WriteLine($"{caunt} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNUm}");
                        return;
                    }

                }
            }
            if(sum < controlNUm)
            {
                Console.WriteLine($"{caunt} moves");
            }
        }
    }
}
