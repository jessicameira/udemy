using System;

namespace udemy_secao6_aula71
{
    class Program
    {
        static void Main(string[] args)
        {
            aluguel[] quartos = new aluguel[10];
            Console.Write("Quantos Quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                Console.Write("#"+i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numero = int.Parse(Console.ReadLine());
                quartos[numero] = new aluguel(nome, email, numero);

            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(quartos[i]);
            }
        }
    }
}
