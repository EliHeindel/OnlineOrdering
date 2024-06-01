using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("1125 W Beylund Loop", "Palmer", "AK", "USA");
            Address address2 = new Address("490 Pioneer Rd", "Rexburg", "ID", "USA");

            // Create customers
            Customer customer1 = new Customer("K. Heindel", address1);
            Customer customer2 = new Customer("E. Heindel", address2);

            // Create products
            Product product1 = new Product("Laptop", "LAP123", 999.99m, 1);
            Product product2 = new Product("Mouse", "MOU456", 25.50m, 2);
            Product product3 = new Product("Keyboard", "KEY789", 49.99m, 1);
            Product product4 = new Product("Monitor", "MON012", 199.99m, 1);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);

            // Display order details
            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

            Console.WriteLine("\nOrder 2:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
        }
    }
}
