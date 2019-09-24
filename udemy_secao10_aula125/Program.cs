using System;
using udemy_secao10_aula125.Entities;
using System.Globalization;

namespace udemy_secao10_aula125
{
    class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            //Account acc = new Account(1001,"Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);
            //Downcasting
            //Account acc1 = bacc;
            //BusinessAccount bacc1 = (BusinessAccount)acc; 

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.1);

            acc1.withdraw(10.0);
            acc2.withdraw(10.0);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
