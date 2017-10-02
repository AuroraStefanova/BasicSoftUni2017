using System;


namespace _13.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main()
        {
            string figures = Console.ReadLine();


            if(figures == "square")
            {
                double someSide = double.Parse(Console.ReadLine());
                double areaSquare = (someSide * someSide);

                Console.WriteLine("{0:##.000}", areaSquare);
            }
            else if(figures == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double areaRectangle = (sideA * sideB);// * 2;

                Console.WriteLine("{0:##.000}", areaRectangle);
            }
            else if(figures == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double areaCircle = Math.PI * r * r;

                Console.WriteLine("{0:##.000}", areaCircle);
            }
            else if(figures == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideH = double.Parse(Console.ReadLine());
                double areaTriangle = (sideA * sideH) / 2;

                Console.WriteLine("{0:##.000}", areaTriangle);
            }
        }
    }
}
