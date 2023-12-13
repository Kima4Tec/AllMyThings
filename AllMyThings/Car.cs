namespace AllMyThings
{
    class Car : IMyThings
    {
        int price = 700000;
        string name = "McLaren";
        string country = "England";

        public Car(int price, string name, string country)
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