using System;
using System.Globalization;

namespace udemy_secao6_aulaVetores2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produtos[] vetor = new Produtos[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Produto: ");
                string name = Console.ReadLine();
                Console.WriteLine("Preco");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[i] = new Produtos(name, preco);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i].Preco;
            }
            double media = soma / n;

            Console.WriteLine("Preco Medio: " + media);
        }
    }
}
