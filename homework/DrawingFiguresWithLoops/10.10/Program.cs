namespace diamonds
{
    using System;

    public class Dia
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var leftRight = (n - 1) / 2;
            var isEven = n % 2 == 0;
            var inside = 2;
            // понеже последния ред е извън цикъла, нямаме контрол над него, 
            // и затова една хакария да не се сърди judge при въведено 1 и 2 :D
            if (n == 1)
            {
                Console.WriteLine('*');
            }
            else if (n == 2)
            {
                Console.WriteLine("**");
            }

            else
            {
                // inside казваме, че е равно на 2, но ако числото е нечетно = 1;
                if (isEven) // first Line - няма нужда да е в цикъла
                {
                    Console.WriteLine("{0}**{0}",
                        new string('-', leftRight));
                }
                else // first Line - няма нужда да е в цикъла
                {
                    Console.WriteLine("{0}*{0}",
                                       new string('-', leftRight));
                    inside = 1;  // ако е нечетно , инсайд е 1 и  печатаме само 1 star
                }
                leftRight--; // намаляме преди цикъла външните тирета 
                while (leftRight >= 0) // въртим докато тиретата са -1 
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', leftRight),
                        new string('-', inside)
                        );
                    leftRight--;  // намаляме тиретата, иначе безкраен цикъл
                    inside += 2; // щом намаляме ляво и дясно с 1,
                                 //за да има симетрия увеличаваме с 2 средата
                }

                // остана да въртим цикъл докато inside = 0 и задачата заспива 
                leftRight = 1; // както е в примера почваме от 1 звезда
                inside = n - 4; // по пътя на логиката първия inside е 2 взеди,
                                // + по едно leftinside от двете страни, значи n -4
                                // щото ширината е N , като махнем 2 взезди става -2,  а отляво
                                // и отдясно имаме по едно leftright - още -2 , общо n -4
                while (inside > 0)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                      new string('-', leftRight),
                      new string('-', inside)
                      );

                    leftRight++;
                    inside -= 2;



                }

                // остава последния ред, направо копи пейст на първи ред от задачата

                if (isEven)
                {
                    Console.WriteLine("{0}**{0}",
                        new string('-', leftRight));
                }
                else // first Line - няма нужда да е в цикъла
                {
                    Console.WriteLine("{0}*{0}",
                                       new string('-', leftRight));
                    inside = 1;
                }
            }

        }
    }
}