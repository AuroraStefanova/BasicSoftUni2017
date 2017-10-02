using System;


namespace _04.TrainersSalary
{
    class Program
    {
        static void Main()
        {
            double numberOfLekcii = double.Parse(Console.ReadLine());
            double monyForPayment = double.Parse(Console.ReadLine());
            var Jelev = 0;
            var RoYaL = 0;
            var Roli = 0;
            var Trofon = 0;
            var Sino = 0;
            var others = 0;
            //za edna lekciq se zaplashta...
            double forOneLection = monyForPayment / numberOfLekcii;

            for (int i = 1; i <= numberOfLekcii; i++)
            {
                string names = Console.ReadLine();
                if(names == "Jelev")
                {
                    Jelev++;
                }
                else if(names == "RoYaL")
                {
                    RoYaL++;
                }
                else if(names == "Roli")
                {
                    Roli++;
                }
                else if(names == "Trofon")
                {
                    Trofon++;
                }
                else if(names == "Sino")
                {
                    Sino++;
                }
                else
                {
                    others++;
                }
            }

            var SelaryJelev = Jelev * forOneLection;
            Console.WriteLine($"Jelev salary: {SelaryJelev:F2} lv");
            var selaruRoYaL = RoYaL * forOneLection;
            Console.WriteLine($"RoYaL salary: {selaruRoYaL:F2} lv");
            var selaryRoli = Roli * forOneLection;
            Console.WriteLine($"Roli salary: {selaryRoli:F2} lv");
            var selaryTrofon = Trofon * forOneLection;
            Console.WriteLine($"Trofon salary: {selaryTrofon:F2} lv");
            var selarySino = Sino * forOneLection;
            Console.WriteLine($"Sino salary: {selarySino:F2} lv");
            var selaryOthers = others * forOneLection;
            Console.WriteLine($"Others salary: {selaryOthers:F2} lv");
        }
    }
}
