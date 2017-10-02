using System;


namespace _04.Bills
{
    class Bills
    {
        static void Main()
        {
            int month = int.Parse(Console.ReadLine());
            double water = 20;
            double net = 15;
            double sumAll = 0;
            double allElectro = 0;
            double other = 0;

            for (int i = 0; i < month; i++)
            {
                double billForElectro = double.Parse(Console.ReadLine());


                sumAll += (water + net + billForElectro);
                allElectro += billForElectro;
                other += billForElectro + net + water;

            }
            double allNet = net * month;
            double allWater = water * month;
            //double other =( water + net + allElectro) * 0.2;
            double allOther = (((other / 100) * 20) + other);
            double avarage = (allElectro + allNet + allWater + allOther) / month;
            Console.WriteLine("Electricity: {0:F2} lv", allElectro);
            Console.WriteLine("Water: {0:F2} lv", allWater);
            Console.WriteLine("Internet: {0:F2} lv", allNet);
            Console.WriteLine("Other: {0:F2} lv", allOther);
            Console.WriteLine("Average: {0:F2} lv", avarage);
        }
    }
}


