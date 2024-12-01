using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Create address
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create Customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Whynot", address2);

        // Create Products
        Product product1 = new Product("Laptop", "L123", 1000, 1);
        Product product2 = new Product("Mouse", "M456", 50, 2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "K789", 100, 1));

        // Display Results
        Console.WriteLine(order1.GetPackingLable());
        Console.WriteLine(order1.GetShippingLable());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLable());
        Console.WriteLine(order2.GetShippingLable());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}