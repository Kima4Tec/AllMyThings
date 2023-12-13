namespace AllMyThings
{

    class Fruit : IMyThings
    {
        int price = 7;
        string name = "apple";
        string country = "Spain";

        public Fruit(int price, string name, string country)
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