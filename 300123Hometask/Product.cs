using System;
using System.Collections.Generic;
using System.Text;

namespace _300123Hometask
{
    internal class Product
    {
        private string _name;
        private double _price;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 20)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Xeta:Adin uzunlugu 2-den az 20-den cox ola bilmez");
                }
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {

                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Xeta:Mehsulun qiymeti 0-dan boyuk olmalidir");
                }
            }
        }

    }
}
