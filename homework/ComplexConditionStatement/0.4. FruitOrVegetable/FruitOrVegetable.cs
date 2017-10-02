using System;


namespace _0._4.FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main()
        {
            string nameOfProduct = Console.ReadLine();

            if((nameOfProduct == "banana")||(nameOfProduct == "apple")||(nameOfProduct == "kiwi")
                ||(nameOfProduct == "cherry")||(nameOfProduct == "lemon")||(nameOfProduct == "grapes"))
            {
                Console.WriteLine("fruit");
            }
            else if((nameOfProduct == "tomato")||(nameOfProduct == "cucumber")||(nameOfProduct == "pepper")
                ||(nameOfProduct == "carrot"))
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
