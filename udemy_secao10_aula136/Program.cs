using System;
using System.Globalization;
using System.Collections.Generic;
using udemy_secao10_aula136.Entities;

namespace udemy_secao10_aula136
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payers> list = new List<Payers>();
            double totaltaxes = 0.0;
            Console.Write("Enter the number of tax Payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} Data:");
                Console.Write("Individual or company (i/c)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income:");
                double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new IndividualPayer(name, anualincome, health));
                }
                else
                {
                    Console.Write("Employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    list.Add(new CompanyPayer(name,anualincome,emp));
                }
            }
            Console.WriteLine();
            foreach(Payers payers in list)
            {
                Console.WriteLine(payers.ToString());
                totaltaxes += payers.TaxePay();
            }
            Console.WriteLine();
            Console.WriteLine("Total: " + totaltaxes);
        }
    }
}
