namespace Restaurant
{
    public class Order
    {
        private static int _index = 1;
        public int Id { get; }
        public int TableNumber { get; }

        public List<MenuItem> Items { get; }

        public OrderStatus Status { get; private set; }

        public Order(int tableNumber)
        {
            Id = _index++;
            TableNumber = tableNumber;
            Items = new List<MenuItem>();
            Status = OrderStatus.New;
        }

        public void AddItem(MenuItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(MenuItem item)
        {
            Items.Remove(item);
        }
        public decimal GetTotalPrice()
        {
            decimal price = 0;
            foreach (MenuItem item in Items)
            {
                price += item.Price;
            }
            return price;
        }

        public void ChangeStatus(OrderStatus status)
        {
            Status = status;
            Console.WriteLine("Змінено статус: " + status);
        }

        public void Print()
        {
            Console.WriteLine($"ID: {Id} | Стіл: {TableNumber} | Статус: {Status} | Сума: {GetTotalPrice()} грн");
        }
    }
}
