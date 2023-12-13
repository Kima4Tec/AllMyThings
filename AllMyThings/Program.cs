using System.ComponentModel.DataAnnotations.Schema;

namespace AllMyThings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IMyThings> allThings = new List<IMyThings>();
            allThings.Add(new Car(70000, "Seat", "Germany"));
            allThings.Add(new Car(80000, "Ford", "USA"));
            allThings.Add(new Animal(20, "Hamster", "Italy"));
            allThings.Add(new Animal(300, "Snake", "Gold Coast"));
            allThings.Add(new Fruit(1, "Orange", "Spain"));
            allThings.Add(new Fruit(3, "Melon", "Japan"));
        
            foreach (var item in allThings)
            {
                Console.WriteLine($"{ item.GetName()} and the price is: { item.GetPrice()} euro.");
            }

        }


    }
}

