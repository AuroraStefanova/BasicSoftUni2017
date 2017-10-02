using System;


namespace _05.Rocket
{
    class Program
    {
        //shirina = 3 * n  visochina 4 *n -1
        //@         ...../\.....  
        /////////// ..../  \.... n 
        /////////// .../    \...
        /////////// ../      \..
        /////////// ..********..
        /////////// ..|\\\\\\|..
        /////////// ..|\\\\\\|..
        /////////// ..|\\\\\\|..
        /////////// ..|\\\\\\|.. n*2
        /////////// ..|\\\\\\|..
        /////////// ..|\\\\\\|..
        /////////// ..|\\\\\\|..
        /////////// ..|\\\\\\|..
        /////////// ../******\..
        /////////// ./********\.n /2 

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // * row 
            for (int i = 1; i <= n /2; i++)
            {
                Console.Write('.');
            }
            for (int i = 1; i <= n*2; i++)
            {
                Console.Write('*');
            }
            for (int i = 1; i <=  n/2; i++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
            //down body 


            for (int cow = 1; cow <= n/2; cow++)
            {
                    Console.Write('.');
            }
            for (int i = 1; i <= n*2; i++)
            {

            }

        }
    }
}
