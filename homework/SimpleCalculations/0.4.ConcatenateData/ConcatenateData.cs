using System;


namespace _0._4.ConcatenateData
{
    class ConcatenateData
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lestName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lestName, age, town);
        }
    }
}
