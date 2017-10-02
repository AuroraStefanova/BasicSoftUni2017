using System;


namespace _12.CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main()
        {
            decimal sum = decimal.Parse(Console.ReadLine());

            var valueInput = Console.ReadLine();
            var  valueOutput = Console.ReadLine();

            decimal firstRate = 0.0m;
            decimal secondRarte = 0.0m;

            if (valueInput == "BGN")
            {
                firstRate = 1;
            }
            else if (valueInput == "USD")
            {
                firstRate = 1.79549m;
            }
            else if (valueInput == "EUR")
            {
                firstRate = 1.95583m;
            }
            else if (valueInput == "GBP")
            {
                firstRate = 2.53405m;
            }
            if (valueOutput == "BGN")
            {
                secondRarte = 1;
            }
            else if (valueOutput == "USD")
            {
                secondRarte = 1.79549m;
            }
            else if (valueOutput == "EUR")
            {
                secondRarte = 1.95583m;
            }
            else if (valueOutput == "GBP")
            {
                secondRarte = 2.53405m;
            }
            decimal result = sum * (firstRate / secondRarte);

            Console.WriteLine("{0} {1}", Math.Round(result,2), valueOutput);
        }
    }
}
