using System;
using System.Diagnostics;

namespace _300123Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Drink
            {
                Name = "NZS",
                Price = 1.20,
                AlcoholPercent1 = 3.5

            };
            Console.WriteLine($"Name: {drink.Name} Price: {drink.Price} Alcohol Percent: {drink.AlcoholPercent1}");
            
            




            
        }
    }
}
