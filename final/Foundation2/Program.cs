class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer = new Customer("John Doe", address);

        double shippingCost = customer.GetShippingCost();
        Console.WriteLine($"Shipping cost: ${shippingCost}");

        customer.DisplayCustomer();
    }
}
