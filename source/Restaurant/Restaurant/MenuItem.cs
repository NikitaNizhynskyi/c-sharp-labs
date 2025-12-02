namespace Restaurant
{
    public abstract class MenuItem
    {
        private static int _index = 1;

        private int _id;
        private string _name;
        private decimal _price;
        private int _calories;

        public int Id => _id;
        public string Name => _name;
        public decimal Price => _price;
        public int Calories => _calories;

        public MenuItem(string name, decimal price, int calories)
        {
            _id = _index++;
            _name = name;
            _price = price;
            _calories = calories;
        }
    }
}
