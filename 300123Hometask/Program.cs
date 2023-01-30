using System;
using System.Diagnostics;

namespace _300123Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Drink();
            string Name;
            do
            {
                Console.WriteLine("Mehsulun adi:");
                Name = Console.ReadLine();

            } while (Chechknumber(Name));

            double Price;
            do
            {
                Console.WriteLine("Mehsulun qiymeti:");
                Price = Convert.ToDouble(Console.ReadLine());

            } while (Price == 0);

            double AlcoholPercent1;
            do
            {

                Console.WriteLine("Alkoqol Faizi:");
                AlcoholPercent1 = Convert.ToDouble(Console.ReadLine());




            } while (AlcoholPercent1 == 0);

        }
        static bool Chechknumber(string Name)
        {
            for (int i = 1; i < Name.Length; i++)
            {
                if (!char.IsDigit(Name[i]))
                    return false;
            }
            return true;
        }
    }
}
