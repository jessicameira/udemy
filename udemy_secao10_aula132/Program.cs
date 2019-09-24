using System;
using System.Globalization;
using System.Collections.Generic;
using udemy_secao10_aula132.Entities;

namespace udemy_secao10_aula132
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i<=n; i++)
            {
                Console.Write($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY)");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs Fee: ");
                    double custfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, custfee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.priceTag());
            }
        }
    }
}
