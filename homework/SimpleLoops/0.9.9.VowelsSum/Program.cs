using System;


namespace _0._9._9.VowelsSum
{
    class Program
    {
        static void Main()
        {
            string someWord = Console.ReadLine();
            double sum = 0;

            for (int i = 0; i < someWord.Length; i++)
            {
                if( someWord[i] == 'a')
                {
                    sum += 1;
                }
                else if( someWord[i] == 'e')
                {
                    sum += 2;
                }
                else if(someWord[i] == 'i')
                {
                    sum += 3;
                }
                else if(someWord[i] == 'o')
                {
                    sum += 4;
                }
                else if(someWord[i] == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
