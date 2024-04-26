using csharp_loja_exercicios.Entities;
using csharp_loja_exercicios.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string clientName = Console.ReadLine();
Console.Write("Email: ");
string clientEmail = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime clientBirth = DateTime.Parse(Console.ReadLine());
Client client = new Client(clientName, clientEmail, clientBirth);

Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

Order order = new Order(DateTime.Now, os, client);

Console.Write("How many products for this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <=n; i++)
{
    Console.WriteLine($"Enter #{i} product data: ");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Product product = new Product(productName, productPrice);

    Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());
    OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
    order.AddItem(orderItem);
}

Console.WriteLine("\n" + order);