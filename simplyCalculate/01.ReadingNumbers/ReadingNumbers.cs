using System;


namespace _01.ReadingNumbers
{
    class ReadingNumbers
    {
        static void Main()
        {
            var firstname = Console.ReadLine();
            var secondName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();

            Console.WriteLine($"Hello my name is {firstname} {secondName}. I am {age} years old and I am from {town}");
        }
    }
}
