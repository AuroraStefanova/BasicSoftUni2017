using System;


namespace _03.Camp
{
    class Program
    {
        static void Main()
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            double numStudents = double.Parse(Console.ReadLine());
            double nightsNum = double.Parse(Console.ReadLine());
            double otstypka = 0;
            double sumNIght = 0;



            if(season == "Winter")
            {
                if(numStudents >= 10 && numStudents < 20)//5%
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 9.60) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 5);
                        Console.WriteLine($"Judo {otstypka:F2} lv.");
                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 9.60) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 5);
                        Console.WriteLine($"Gymnastics {otstypka:F2} lv.");
                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 10) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 5);
                        Console.WriteLine($"Ski {otstypka:F2} lv.");
                    }
                }
                if(numStudents >=20 && numStudents < 50)//15  %
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 9.60) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 15);
                        Console.WriteLine($"Judo {otstypka:F2} lv.");
                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 9.60) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 15);
                        Console.WriteLine($"Gymnastics {otstypka:F2} lv.");
                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 10) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 15);
                        Console.WriteLine($"Ski {otstypka:F2} lv.");
                    }
                }
                if(numStudents >= 50)//50%
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 9.60) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 50);
                        Console.WriteLine($"Judo {otstypka:F2} lv.");
                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 9.60) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 50);
                        Console.WriteLine($"Gymnastics {otstypka:F2} lv.");
                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 10) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 50);
                        Console.WriteLine($"Ski {otstypka:F2} lv.");
                    }
                }
                if(numStudents <10)
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 9.60) * nightsNum;
                        Console.WriteLine($"Judo {sumNIght:F2} lv.");

                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 9.60) * nightsNum;
                        Console.WriteLine($"Gymnastics {sumNIght:F2} lv.");
                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 10) * nightsNum;
                        Console.WriteLine($"Ski {sumNIght:F2} lv.");
                    }
                }
            }
            if(season == "Spring")
            {
                if (numStudents >= 10 && numStudents < 20)//5%
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 7.20) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 5);
                        Console.WriteLine($"Tennis {otstypka:F2} lv.");
                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 7.20) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 5);
                        Console.WriteLine($"Athletics {otstypka:F2} lv.");

                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 9.50) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 5);
                        Console.WriteLine($"Cycling {otstypka:F2} lv.");

                    }
                }
                if (numStudents >= 20 && numStudents < 50)//15  %
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 7.20) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 15);
                        Console.WriteLine($"Tennis {otstypka:F2} lv.");

                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 7.20) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 15);
                        Console.WriteLine($"Athletics {otstypka:F2} lv.");

                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 9.50) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 15);
                        Console.WriteLine($"Cycling {otstypka:F2} lv.");

                    }
                }
                if (numStudents >= 50)//50%
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 7.20) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 50);
                        Console.WriteLine($"Tennis {otstypka:F2} lv.");


                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 7.20) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 50);
                        Console.WriteLine($"Athletics {otstypka:F2} lv.");

                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 9.50) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 50);
                        Console.WriteLine($"Cycling {otstypka:F2} lv.");

                    }
                }
                if(numStudents < 10)
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 7.20) * nightsNum;
                        Console.WriteLine($"Tennis {sumNIght:F2} lv.");

                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 7.20) * nightsNum;
                        Console.WriteLine($"Athletics {sumNIght:F2} lv.");

                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 9.50) * nightsNum;
                        Console.WriteLine($"Cycling {sumNIght:F2} lv.");

                    }
                }
            }
            if(season == "Summer")
            {
                if (numStudents >= 10 && numStudents < 20)//5%
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 15) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 5);
                        Console.WriteLine($"Football {otstypka:F2} lv.");

                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 15) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 5);
                        Console.WriteLine($"Volleyball {otstypka:F2} lv.");


                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 20) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 5);
                        Console.WriteLine($"Swimming {otstypka:F2} lv.");

                    }
                }
                if (numStudents >= 20 && numStudents < 50)//15  %
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 15) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 15);
                        Console.WriteLine($"Football {otstypka:F2} lv.");


                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 15) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 15);
                        Console.WriteLine($"Volleyball {otstypka:F2} lv.");

                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 20) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 15);
                        Console.WriteLine($"Swimming {otstypka:F2} lv.");
                    }
                }
                if (numStudents >= 50)//50%
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 15) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 50);
                        Console.WriteLine($"Football {otstypka:F2} lv.");

                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 15) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 50);
                        Console.WriteLine($"Volleyball {otstypka:F2} lv.");

                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 20) * nightsNum;
                        otstypka = sumNIght - ((sumNIght / 100) * 50);
                        Console.WriteLine($"Swimming {otstypka:F2} lv.");
                    }
                    
                }
                if(numStudents <10)
                {
                    if (group == "boys")
                    {
                        sumNIght = (numStudents * 15) * nightsNum;
                        Console.WriteLine($"Football {sumNIght:F2} lv.");

                    }
                    if (group == "girls")
                    {
                        sumNIght = (numStudents * 15) * nightsNum;
                        Console.WriteLine($"Volleyball {sumNIght:F2} lv.");

                    }
                    if (group == "mixed")
                    {
                        sumNIght = (numStudents * 20) * nightsNum;
                     
                        Console.WriteLine($"Swimming {sumNIght:F2} lv.");
                    }
                }
            }
        }
    }
}
