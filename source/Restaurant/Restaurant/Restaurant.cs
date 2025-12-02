namespace Restaurant
{
    public class Restaurant
    {
        public List<MenuItem> Items { get; }
        public List<Order> Orders { get; }
        public Restaurant()
        {
            Items = new List<MenuItem>();
            Orders = new List<Order>();
        }

        public void AddItem(MenuItem item)
        {
            Items.Add(item);
            Console.WriteLine("Додано позицію: " + item.Name);
        }

        public void RemoveItem(MenuItem item)
        {
            Items.Remove(item);
            Console.WriteLine("Видалено позицію: " + item.Name);
        }

        public void CreateOrder(Order order)
        {
            Orders.Add(order);
        }
        public void PrintAllOrders()
        {
            Console.WriteLine("--- УСІ ЗАМОВЛЕННЯ ---");
            foreach (var order in Orders)
            {
                order.Print();
            }
        }
    }
}
