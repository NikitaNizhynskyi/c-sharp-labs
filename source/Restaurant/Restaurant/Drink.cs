namespace Restaurant
{
    public class Drink : MenuItem
    {
        public DrinkCategory Category { get; }
        public double Volume { get; }
        public double AlcoholPercentage { get; }

        public Drink(string name, decimal price, int calories, DrinkCategory category, double volume, double alcoholPercentage) : base(name, price, calories)
        {
            Category = category;
            Volume = volume;
            AlcoholPercentage = alcoholPercentage;
        }

    }
}
