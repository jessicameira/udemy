using System;
using System.Globalization;
using System.Collections.Generic;
using udemy_secao10_aula130.Entities;

namespace udemy_secao10_aula130
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Emplooy n#{i} data:");
                Console.Write("Outsourced(Y/N): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double addcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourced(name, hours, valueperhour, addcharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueperhour));
                } 
            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + "- $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
