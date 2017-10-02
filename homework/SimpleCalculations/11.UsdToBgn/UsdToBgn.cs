using System;


namespace _11.UsdToBgn
{
    class UsdToBgn
    {
        static void Main()
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = 1.79549 * usd;

            Console.WriteLine("{0: ##.00 BGN}", bgn );
        }
    }
}
