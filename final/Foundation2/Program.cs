using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1: USA Customer ---
        Console.WriteLine("--- Order 1: USA Customer ---");
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Product product1a = new Product("Laptop", "TECH001", 1200.00m, 1);
        Product product1b = new Product("Mouse", "ACC005", 25.00m, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1a);
        order1.AddProduct(product1b);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\n" + order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Order Cost: ${order1.CalculateTotalCost():0.00}");

        Console.WriteLine("\n" + new string('-', 30) + "\n"); // Separator

        // --- Order 2: International Customer ---
        Console.WriteLine("--- Order 2: International Customer ---");
        Address address2 = new Address("45 Rue de la Paix", "Paris", "Ile-de-France", "France");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product2a = new Product("French Press", "KIT010", 45.00m, 1);
        Product product2b = new Product("Coffee Beans", "FOOD020", 15.50m, 3);
        Product product2c = new Product("Mug Set", "KIT015", 30.00m, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2a);
        order2.AddProduct(product2b);
        order2.AddProduct(product2c);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\n" + order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Order Cost: ${order2.CalculateTotalCost():0.00}");
    }
}