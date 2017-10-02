using System;


namespace _06.Battles
{
    class Program
    {
        static void Main()
        {
            int firstPokemon = int.Parse(Console.ReadLine());
            int secondPokemon = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            double caunt = 0;

            for (int i = 1; i <= firstPokemon ; i++)
            {
                for (int j = 1; j <= secondPokemon; j++)
                {
                    caunt++;
                     if(caunt >=  maxBattles)
                    {
                        Console.Write($"({i} <-> {j}) ");
                        return;

                    }
                    Console.Write($"({i} <-> {j}) ");
                }
            }
        }
    }
}
