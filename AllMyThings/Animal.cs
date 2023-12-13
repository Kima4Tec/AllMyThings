using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMyThings
{
    class Animal : IMyThings
    {
    int price = 70;
    string name = "Hippopotamus";
        string country = "Danmark";

        public Animal(int price, string name, string country)
        {
            this.price = price;
            this.name = name;
            this.country = country;
        }
        public string GetName()
        {
            return $"Name of {GetType().Name}: {name} ({country})";
        }

        public double GetPrice()
        {
            return price;
        }
    }
}
