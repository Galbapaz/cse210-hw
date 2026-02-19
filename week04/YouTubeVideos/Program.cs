using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "A100", 1200, 1));
        order1.AddProduct(new Product("Mouse", "B200", 25, 2));

        
        Address address2 = new Address("456 Central Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Maria Lopez", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "C300", 800, 1));
        order2.AddProduct(new Product("Headphones", "D400", 150, 1));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("----- PACKING LABEL -----");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("----- SHIPPING LABEL -----");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine("Total Cost: $" + order.CalculateTotalCost());
            Console.WriteLine("\n=========================\n");
        }
    }
}
