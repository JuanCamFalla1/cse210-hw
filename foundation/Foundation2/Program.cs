using System;

class Program
{
    static void Initialize(List<Order> orders)
        {
        List<Product> products = new List<Product>(); Customer customer;
        Address address; Product product;Order order;
        address = new Address("789 Main Street", "tampa", "FL", "USA");
        customer = new Customer("Oliver", address);
        product = new Product("Diappers", "K233234", 15, 2);
        products.Add(product);
        product = new Product("pacifier", "217789d", 19.5, 1);
        products.Add(product);
        product = new Product("Milk", "fasdf842", 8.5, 15);
        products.Add(product);
        order = new Order(products, customer);

        orders.Add(order);
        products = new List<Product>();
        address = new Address("3471 w Briarpark dr", "Bogota", "DT", "Colombia");
        customer = new Customer("Tiago", address);
        product = new Product("Bulbasor Toy", "Toe4501674", 3.79, 5);
        products.Add(product);
        product = new Product("Candies", "Gum45795", 3, 5);
        products.Add(product);
        product = new Product("Lightsaber", "lig12384", 25.99, 1);
        products.Add(product);
        order = new Order(products, customer);

        orders.Add(order);  

    }

    static void Main(string[] args)
    {
         List<Order> orders = new List<Order>();
        Initialize(orders);
        foreach(Order order in orders)
        {
            Console.WriteLine("Packing Label");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine("Shipping Label");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Shipping Price: ${order.GetShippingPrice()}.00");
            Console.WriteLine($"Total Price: ${Math.Round(order.CalcTotalPrice(), 2)}\n");
        }
    }
}
