using System;


namespace _0._9.VowelsSum
{
    class VowelsSum
    {
        static void Main()
        {
            string someWord = Console.ReadLine();
            double sum = 0;
            
            for (int i = 0; i < someWord.Length; i++)
            {
                var word = someWord[i]
                switch (someWord)
                {
                    case "a":
                        Console.WriteLine(+1);
                        break;
                    case "e":
                        Console.WriteLine(+2);
                        break;
                    case "i":
                        Console.WriteLine(+3);
                        break;
                    case "o":
                        Console.WriteLine(+4);
                        break;
                    case "u":
                        Console.WriteLine(+5);
                        break;
                    default:
                        Console.WriteLine();
                        break;

                }
                //double sum = someWord.Length;

            }
            Console.WriteLine(sum);
        }
    }
}
