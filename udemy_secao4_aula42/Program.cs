using System;
using System.Globalization;

namespace udemy_secao4_aula42
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entro com os dados do produto:");
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(name, preco, quantidade);

            Console.WriteLine("Dados do produto : " + p);

            Console.WriteLine("Quantidade a ser adicionada: ");
            int qte = int.Parse(Console.ReadLine());
            p.adicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);
            
            Console.WriteLine("Quantidade a ser removida: ");
            qte = int.Parse(Console.ReadLine());
            p.removerProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
