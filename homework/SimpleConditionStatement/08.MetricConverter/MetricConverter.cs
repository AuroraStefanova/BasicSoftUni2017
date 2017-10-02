using System;


namespace _08.MetricConverter
{
    class MetricConverter
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            double firstMatric = 0;

            if(input == "yd")
            {
                if(output == "mm")
                {
                    firstMatric = (number * 914.4);
                }
                else if(output == "ft")
                {
                    firstMatric = (number * 3);
                }
                else if(output == "cm")
                {
                    firstMatric = (number * 91.44);
                }
                else if(output == "m")
                {
                    firstMatric = (number * 0.9144);
                }
                else if(output == "mi")
                {
                    firstMatric = (number * 0.000568181818);
                }
                else if( output == "in")
                {
                    firstMatric = (number * 36);
                }
                else if(output == "km")
                {
                    firstMatric = (number * 0.0009144);
                }
                else if(output == "yd")
                {
                    firstMatric = number;
                }
            }
            if(input == "ft")
            {
                if(output == "cm")
                {
                    firstMatric = (number * 30.48);
                }
                else if(output == "m")
                {
                    firstMatric = (number * 0.3048);
                }
                else if(output == "mm")
                {
                    firstMatric = (number * 304.8);
                }
                else if(output == "in")
                {
                    firstMatric = (number * 12);
                }
                else if(output == "yd")
                {
                    firstMatric = (number * 0.333333333);
                }
                else if(output == "km")
                {
                    firstMatric = (number * 0.0003048);
                }
                else if(output == "mi")
                {
                    firstMatric = (number * 0.000189393939);
                }
                else if(output == "ft")
                {
                    firstMatric = number;
                }
            }
            if(input == "km")
            {
                if(output == "cm")
                {
                    firstMatric = (number * 100000);
                }
                else if(output == "mi")
                {
                    firstMatric = (number * 0.621371192);
                }
                else if(output == "in")
                {
                    firstMatric = (number * 39370.0787);
                }
                else if(output == "yd")
                {
                    firstMatric = (number * 1093.6133);
                }
                else if(output == "m")
                {
                    firstMatric = (number * 1000);
                }
                else if(output == "mm")
                {
                    firstMatric = (number * 1000000);
                }
                else if(output == "ft")
                {
                    firstMatric = (number * 3280.8399);
                }
                else if(output == "km")
                {
                    firstMatric = number;
                }
            }
            if(input == "in")
            {
                if(output == "cm")
                {
                    firstMatric = (number * 2.54);
                }
                else if(output == "ft")
                {
                    firstMatric = (number * 0.0833333333);
                }
                else if(output == "m")
                {
                    firstMatric = (number * 0.0254);
                }
                else if(output == "yd")
                {
                    firstMatric = (number * 0.0277777778);
                }
                else if(output == "mm")
                {
                    firstMatric = (number * 25.4);
                }
                else if(output == "mi")
                {
                    firstMatric = (number * 0.0000157828283);
                }
                else if(output == "km")
                {
                    firstMatric = (number * 0.0000254);
                }
                else if(output == "in")
                {
                    firstMatric = number;
                }
            }
            if(input == "mi")
            {
                if(output == "km")
                {
                    firstMatric = (number * 1.609344);
                }
                else if(output == "m")
                {
                    firstMatric = (number * 1609.344);
                }
                else if(output == "cm")
                {
                    firstMatric = (number * 160934.4);
                }
                else if(output == "mm")
                {
                    firstMatric = (number * 1609344);
                }
                else if(output == "ft")
                {
                    firstMatric = (number * 5280);
                }
                else if(output == "yd")
                {
                    firstMatric = (number * 1760);
                }
                else if(output == "in")
                {
                    firstMatric = (number * 63360);
                }
                else if(output == "mi")
                {
                    firstMatric = number;
                }
            }
            if(input == "mm")
            {
                if(output == "m")
                {
                    firstMatric = (number * 0.001);
                }
                else if( output == "cm")
                {
                    firstMatric = (number * 0.1);
                }
                else if(output == "km")
                {
                    firstMatric = (number * 0.000001);
                }
                else if(output == "mi")
                {
                    firstMatric = (number * 0.0000001609344);//!!!!!!!39.3700787401575//6.2137119223733//
                }
                else if(output == "ft")
                {
                    firstMatric = (number * 0.0032808399);
                }
                else if(output == "in")
                {
                    firstMatric = (number * 0.0393700787);
                }
                else if(output == "yd")
                {
                    firstMatric = (number * 0.0010936133);
                }
                else if(output == "mm")
                {
                    firstMatric = number;
                }
            }
            if(input == "cm")
            {
                if(output == "m")
                {
                    firstMatric = (number * 0.01);
                }
                else if(output == "mm")
                {
                    firstMatric = (number * 10);
                }
                else if(output == "km")
                {
                    firstMatric = (number * 0.00001000000);
                }
                else if( output == "ft")
                {
                    firstMatric = (number * 0.032808399);
                }
                else if(output == "in")
                {
                    firstMatric = (number * 0.393700787);
                }
                else if(output == "yd")
                {
                    firstMatric = (number * 0.010936133);
                }
                else if(output == "mi")
                {
                    firstMatric = (number * 0.000006213712);
                }
                else if(output == "cm")
                {
                    firstMatric = number;
                }
            }
            if(input == "m")
            {
                if(output == "mm")
                {
                    firstMatric = (number * 1000);
                }
                else if(output == "cm")
                {
                    firstMatric = (number * 100);
                }
                else if(output == "mi")
                {
                    firstMatric = (number * 0.000621371192);
                }
                else if(output == "in")
                {
                    firstMatric = (number * 39.3700787);
                }
                else if(output == "km")
                {
                    firstMatric = (number * 0.001);
                }
                else if(output == "ft")
                {
                    firstMatric = (number * 3.2808399);
                }
                else if(output == "yd")
                {
                    firstMatric = (number * 1.0936133);
                }
                else if(output == "m")
                {
                    firstMatric = number;
                }
            }
            Console.WriteLine("{0} {1}",firstMatric, output);
        }
    }
}
