using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {

        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple Ave", "Vancouver", "BC", "Canada");

    
        Customer customer1 = new Customer("Gwen Stacy", address1);
        Customer customer2 = new Customer("Wade Wilson", address2);

        Product product1 = new Product("Neck Brace", "A001", 12.99, 2);
        Product product2 = new Product("Bell", "B002", 1.99, 5);
        Product product3 = new Product("Pen", "C003", 5.49, 3);
        Product product4 = new Product("Spackle", "D004", 25.00, 1);

        List<Product> order1Products = new List<Product> { product1, product2 };
        Order order1 = new Order(customer1, order1Products);

        List<Product> order2Products = new List<Product> { product3, product4 };
        Order order2 = new Order(customer2, order2Products);

    
        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine("=== ORDER ===");
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("------------------------\n");
        }
    }
}