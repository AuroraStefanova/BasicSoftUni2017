using System;


namespace _13.thousandDaysAfterBirth
{
    class thousandDaysAfterBirth
    {
        static void Main()
        {
            string birthday = Console.ReadLine();
            DateTime date = DateTime.ParseExact(birthday, "dd-MM-yyyy", null);
            date = date.AddDays(999);

            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }
}
