using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(
            new Product("Laptop", "P100", 899.99, 1));

        order1.AddProduct(
            new Product("Mouse", "P101", 25.99, 2));

        order1.AddProduct(
            new Product("Keyboard", "P102", 49.99, 1));

        // Customer 2 (Canada)
        Address address2 = new Address(
            "456 Maple Road",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer(
            "Emily Johnson",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(
            new Product("Monitor", "P200", 299.99, 2));

        order2.AddProduct(
            new Product("Webcam", "P201", 79.99, 1));

        order2.AddProduct(
            new Product("Headset", "P202", 59.99, 1));

        // Display Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(
            $"Total Cost: ${order1.CalculateTotalCost():F2}");

        // Display Order 2
        Console.WriteLine("\n==============================\n");

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(
            $"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}