class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget", "W123", 19.99m, 2));
        order1.AddProduct(new Product("Gadget", "G456", 24.99m, 1));

        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Thingamajig", "T789", 14.99m, 3));
        order2.AddProduct(new Product("Doohickey", "D012", 29.99m, 2));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: {order.GetTotalCost()}");
            Console.WriteLine();
        }
    }
}
