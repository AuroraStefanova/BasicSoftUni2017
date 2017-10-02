using System;


namespace _06.StupidPasswordGenerator
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (char i = '1'; i <= '1' + n; i++)
            {
                for (char j = '1'; j <='1' + n; j++)
                {
                    for (char k = 'a'; k <'a' + l; k++)
                    {
                        for (char m = 'a'; m <'a' +l; m++)
                        {
                            for (char q = (char)(Math.Max(i, j) +1); q < '1' +n; q++)
                            {
                                Console.Write($"{i}{j}{k}{m}{q} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
