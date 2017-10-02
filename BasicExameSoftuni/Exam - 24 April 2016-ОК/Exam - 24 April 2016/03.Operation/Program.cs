using System;


namespace _03.Operation
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double sum = 0;

            var operators = Console.ReadLine();

            if (operators == "+")
            {
                sum = n + m;
                if(sum % 2 == 0)
                {
                    Console.WriteLine($"{n} {operators} {m} = {sum} - even ");
                }
                else
                {
                    Console.WriteLine($"{n} {operators} {m} = {sum} - odd ");

                }
            }
            if(operators == "-")
            {
                sum = n - m;
                if(sum % 2 == 0)
                {
                    Console.WriteLine($"{n} {operators} {m} = {sum} - even ");

                }
                else
                {
                    Console.WriteLine($"{n} {operators} {m} = {sum} - odd ");

                }
            }
            if(operators == "*")
            {
                sum = n * m;
                if(sum % 2 == 0)
                {
                    Console.WriteLine($"{n} {operators} {m} = {sum} - even ");

                }
                else
                {
                    Console.WriteLine($"{n} {operators} {m} = {sum} - odd ");

                }
            }
            if(operators == "/")
            {
                
                if(m == 0)
                {
                    Console.WriteLine($"Cannot divide {n} by zero");
                }

                else
                {
                    sum = n / m;
                    Console.WriteLine("{0} / {1} = {2:F2}", n, m, sum);
                }
            }
            if(operators == "%")
            {
                
                if(m == 0)
                {
                    Console.WriteLine($"Cannot divide {n} by zero");
                }
                else
                {
                    sum = n % m;
                    Console.WriteLine($"{n} % {m} = {sum}");

                }
            }

        }
    }
}
