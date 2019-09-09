using System;
using System.Collections.Generic;
using System.Globalization;

namespace udemy_secao6_aula78
{
    class Program
    {
        static void Main(string[] args)
        {
            List<funcionarios> func = new List<funcionarios>();
            Console.WriteLine("Quantos funcionarios serão cadastrados?");
            int n1 = int.Parse(Console.ReadLine());
            for(int i = 0; i < n1; i++)
            {
                Console.WriteLine("Id do funcionario: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome do funcionario: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios funcionario = new funcionarios(id, nome, salario);

                func.Add(funcionario);
            }
            Console.WriteLine("Escolha o funcionario a ter aumento de salario: ");
            int idFunc = int.Parse(Console.ReadLine());

            funcionarios empregados = func.Find(x => x.Id == idFunc);
            if (idFunc != null)
            {
                Console.WriteLine("Porcentagem de aumento: ");
                double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empregados.aumentoSalario(perc);
            }
            else
            {
                Console.WriteLine("Codigo invalido!" );
            }
            Console.WriteLine("Dados Atualizados: ");
            foreach (funcionarios emp in func)
            {
                Console.WriteLine(emp);
            }
            
            
        }
    }
}
