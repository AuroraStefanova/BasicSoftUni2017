using System;


namespace _09.PasswordGuess
{
    class PasswordGuess
    {
        static void Main()
        {
            string pass = Console.ReadLine();
            string correctPass = "s3cr3t!P@ssw0rd";

            if ( pass != correctPass )
            {
                Console.WriteLine("Wrong password!");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
