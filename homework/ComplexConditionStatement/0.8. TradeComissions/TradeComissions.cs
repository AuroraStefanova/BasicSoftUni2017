using System;


namespace _0._8.TradeComissions
{
    class TradeComissions
    {
        static void Main()
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0;

            if((town == "Sofia")||(town == "sofia"))
            {
                if((sales >= 0)&&(sales <= 500))
                {
                    comission = 0.05;
                }
                else if((sales > 500)&&(sales <= 1000))
                {
                    comission = 0.07;
                }
                else if((sales > 1000)&&(sales <= 10000))
                {
                    comission = 0.08;
                }
                else if(sales > 10000)
                {
                    comission = 0.12;
                }
                else if(sales < 0)
                {
                    Console.WriteLine("error");
                }
            }

            else if((town == "Varna")||(town == "varna"))
            {
                if ((sales >= 0) && (sales <= 500))
                {
                    comission = 0.045;
                }
                else if ((sales > 500) && (sales <= 1000))
                {
                    comission = 0.075;
                }
                else if ((sales > 1000) && (sales <= 10000))
                {
                    comission = 0.10;
                }
                else if (sales > 10000)
                {
                    comission = 0.13;
                }
                else if(sales < 0 )
                {
                    Console.WriteLine("error");
                }
            }

            else if((town == "Plovdiv")||(town == "plovdiv"))
            {
                if ((sales >= 0) && (sales <= 500))
                {
                    comission = 0.055;
                }
                else if ((sales > 500) && (sales <= 1000))
                {
                    comission = 0.08;
                }
                else if ((sales > 1000) && (sales <= 10000))
                {
                    comission = 0.12;
                }
                else if (sales > 10000)
                {
                    comission = 0.145;
                }
                else if(sales < 0)
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            double sum = (sales * comission);

            Console.WriteLine("{0:F2}",sum);
        }
    }
}
