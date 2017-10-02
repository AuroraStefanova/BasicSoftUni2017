using System;


namespace _06.LettersCombinations
{
    class Program
    {
        static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            var stop = char.Parse(Console.ReadLine());
            int caunt = 0;
            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        
                        if(i == stop)
                        {
                            continue;
                        }
                        else if( j == stop)
                        {
                            continue;
                        }
                        else if(k == stop)
                        {
                            continue;
                        }

                        else
                        {
                            Console.Write($"{i}{j}{k} ");

                        }
                        caunt++;
                    }
                }
            }
            Console.Write($"{caunt} ");

        }
    }
}
