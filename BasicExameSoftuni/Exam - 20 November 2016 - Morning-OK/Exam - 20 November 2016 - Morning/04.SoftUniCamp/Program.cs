using System;


namespace _04.SoftUniCamp
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double five = 0;
            double twelve = 0;
            double twentifive = 0;
            double forty = 0;
            double fortiOne = 0;
            double count = 0;


            for (int i = 1; i <= n; i++)
            {
                int P = int.Parse(Console.ReadLine());

                if( P <= 5)
                {
                    five += P;

                }
                if(P > 5 && P <= 12)
                {
                    twelve += P;

                }
                if(P >=13 && P <= 25)
                {
                    twentifive += P;


                }
                if(P >= 26 && P <= 40)
                {
                    forty += P;

                }
                if(P >= 41)
                {
                    fortiOne += P;
                }
                count++;
            }
            double all = five + twelve + twentifive + forty + fortiOne;
            double car = (five / all) * 100;
            Console.WriteLine($"{car:F2}%");
            double bus = (twelve / all) * 100;
            Console.WriteLine($"{bus:F2}%");
            double autobus = (twentifive / all) * 100;
            Console.WriteLine($"{autobus:F2}%");
            double big = (forty / all) * 100;
            Console.WriteLine($"{big:F2}%");
            double train = (fortiOne / all) * 100;
            Console.WriteLine($"{train:F2}%");

        }
    }
}
