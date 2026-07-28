using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "15 Oak Street",
            "Cape Town",
            "Western Cape",
            "South Africa");

        Customer customer1 = new Customer(
            "Elphus Ngobeni",
            address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(
            new Product("Wireless Mouse", "P1001", 299.99, 2));

        order1.AddProduct(
            new Product("Keyboard", "P1002", 499.99, 1));

        Address address2 = new Address(
            "82 Maple Avenue",
            "Dallas",
            "Texas",
            "USA");

        Customer customer2 = new Customer(
            "Sarah Adams",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(
            new Product("Laptop Stand", "P2001", 699.99, 1));

        order2.AddProduct(
            new Product("USB Hub", "P2002", 249.99, 2));

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}