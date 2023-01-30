using System;
using System.Collections.Generic;
using System.Text;

namespace _300123Hometask
{
    internal class Drink : Product
    {
        private double _alcoholPercent;

        public double AlcoholPercent1
        {
            get
            {
                return _alcoholPercent;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    _alcoholPercent = value;
                }
                else
                {
                    Console.WriteLine("Xeta:Alkoqol Faizi 0-100 araliginda olmalidir");
                }
            }
        }
    }
}
