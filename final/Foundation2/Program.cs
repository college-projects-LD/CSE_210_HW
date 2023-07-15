using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create customers
        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Jane Smith", new Address("456 Elm St", "Toronto", "ON", "Canada"));

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Product1", 1, 10.99, 2));
        order1.AddProduct(new Product("Product2", 2, 15.99, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Product3", 3, 20.99, 1));
        order2.AddProduct(new Product("Product4", 4, 25.99, 3));

        // Display order details
        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine("\nOrder 2");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}
