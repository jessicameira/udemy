using System;
using udemy_secao9_aula122.Entities;
using udemy_secao9_aula122.Entities.Enums;
using System.Globalization;

namespace udemy_secao9_aula122
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client DATA:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento: (DD/MM/YYYY)");
            DateTime bday = DateTime.Parse(Console.ReadLine());

            Client cliente = new Client(nome, email, bday);

            Console.WriteLine("Enter Order DATA:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("Hoow many itens to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(status, cliente);
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter "+ i +" item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtt = int.Parse(Console.ReadLine());
                Products product = new Products(productName, productPrice);
                OrderItem items = new OrderItem(qtt, productPrice, product);
                order.AddItem(items);
            }
            Console.WriteLine("ODERDER SUMMARY:");
            Console.WriteLine(order); 
            Console.WriteLine();
      
        }
    }
}
