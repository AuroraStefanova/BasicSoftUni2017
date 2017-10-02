using System;


namespace _06.Generator
{
    class Program
    {
        static void Main()
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());

            int specialNum = int.Parse(Console.ReadLine());
            int contNum = int.Parse(Console.ReadLine());
            
            for (int i = M; i >= 1; i--)
            {
                for (int j = N; j >= 1; j--)
                {
                    for (int k = L; k >= 1; k--)
                    {
                       
                       if(((i*100)+(j*10)+k) % 3 == 0)
                       {
                           specialNum += 5;
                            continue;
                       }
                       else if(k == 5)
                       {
                           specialNum -= 2;

                       }
                       else if(((i * 100) + (j * 10) + k) % 2 == 0)
                       {
                           specialNum *= 2;
                       }

                       if(specialNum >= contNum)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
                            return;
                        }

                    }
                }
            }
            if (specialNum < contNum)
            {
                Console.WriteLine($"No! {specialNum} is the last reached special number.");

            }

        }
    }
}
