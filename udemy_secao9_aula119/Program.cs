using System;
using udemy_secao9_aula119.Entities.Enums;
using udemy_secao9_aula119.Entities;
using System.Globalization;

namespace udemy_secao9_aula119
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Departament: ");
            string deptName = Console.ReadLine();
            Console.Write("Enter Worker Date: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter level: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Enter Base Salary: ");
            double BaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departaments dept = new Departaments(deptName);
            Worker worker = new Worker(name, level, BaseSalary, dept);

            Console.Write("How many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter #{i} ");
                Console.Write("Date (DD/MM/YYYY) ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration: ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valueperhour, hours);

                worker.AddContract(contract);
            }

            Console.Write("Enter Month and yer to calculate the Income ");
            string monthyear = Console.ReadLine();
            int month = int.Parse(monthyear.Substring(0, 2));
            int year = int.Parse(monthyear.Substring(3));

            Console.WriteLine("Name: " + worker.Nome) ;
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthyear + ": " + worker.Income(month, year)) ;

        }
    }
}
