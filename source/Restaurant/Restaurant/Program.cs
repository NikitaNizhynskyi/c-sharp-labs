namespace Restaurant
{
    public class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            Dish varenyky = new Dish("Вареники", 120m, 200, DishCategory.MainCourses, 200.0);
            Dish borsch = new Dish("Борщ", 130m, 250, DishCategory.FirstCourses, 180.0);
            Drink tea = new Drink("Чай", 60m, 24, DrinkCategory.Tea, 200.0, 0.0);


            restaurant.AddItem(varenyky);
            restaurant.AddItem(borsch);
            restaurant.AddItem(tea);

            Order order1 = new Order(5);
            order1.AddItem(varenyky);
            order1.AddItem(borsch);
            order1.AddItem(tea);

            restaurant.CreateOrder(order1);
            Console.WriteLine("Поточна сума: " + order1.GetTotalPrice() + "грн");

            Console.WriteLine("Статус замовлення: " + order1.Status);

            order1.ChangeStatus(OrderStatus.InProgress);
            order1.ChangeStatus(OrderStatus.Ready);
            order1.ChangeStatus(OrderStatus.Paid);

            restaurant.PrintAllOrders();
        }
    }
}
