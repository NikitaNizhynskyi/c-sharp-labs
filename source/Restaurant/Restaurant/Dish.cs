namespace Restaurant
{
    public class Dish : MenuItem
    {
        public DishCategory Category { get; }
        public double Weight { get; }

        public Dish(string name, decimal price, int calories, DishCategory category, double weight) : base(name, price, calories)
        {
            Category = category;
            Weight = weight;
        }

    }
}
