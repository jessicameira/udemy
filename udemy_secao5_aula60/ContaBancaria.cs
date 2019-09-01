using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace udemy_secao5_aula60
{
    class ContaBancaria
    {
        public string Nome { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; set; }

        public ContaBancaria(string nome, int conta)
        {
            Nome = nome;
            Numero = conta;
        }

        public ContaBancaria(string nome, int conta, double saldo) : this(nome, conta)
        {
            Saldo = saldo;
        }

        public void Deposito(double deposito)
        {
            Saldo = Saldo + deposito;
        }

        public void Saque(double saque)
        {
            Saldo = Saldo - (saque + 5.00);
        }


        public override string ToString()
        {
            return "Titular: "
                + Nome
                + ", Numero: "
                + Numero
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
