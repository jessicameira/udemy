using System;
using System.Globalization;

namespace udemy_secao5_aula60
{
    class Program
    {
        ContaBancaria conta;
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Digite o Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Terá deposito inicial? (S/N): ");
            char opcao = char.Parse(Console.ReadLine());

            if ( opcao == 'S' || opcao == 's')
            {
                Console.Write("Qual é o valor do deposito? ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nome, numero, deposito);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
            }
            else
            {
                conta = new ContaBancaria(nome, numero);
                Console.WriteLine("Dados da Conta: ");
                Console.WriteLine(conta);
            }

            Console.Write("Informe a Quantia para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Conta atualizada! " + conta);

            Console.WriteLine();
            Console.Write("Informe a quantia para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Conta atualizada! " + conta);
        }
    }
}
