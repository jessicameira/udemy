using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_secao10_aula125.Entities
{
    //sealed serve para que a classe não possa ser 
    //herdada ou que um metodo seja sobreposto seja sobreposto novamente 
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) :base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        public override void withdraw(double amount)
        {
            //Caso seja  necessário alterar a operação na subclasse.
            //Balance -= amount;
            base.withdraw(amount);
            Balance -= 2.0;
        }
    }
}
