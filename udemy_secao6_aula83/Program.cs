using System;
using System.Collections.Generic;

namespace udemy_secao6_aula83
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            HashSet<int> contagem = new HashSet<int>();

            Console.WriteLine("Quantidade de Alunos curso A:");
            int n1 = int.Parse(Console.ReadLine());
            for(int i = 0; i < n1; i++)
            {
                Console.WriteLine("Digite o código do Aluno: ");
                int aluno = int.Parse(Console.ReadLine());
                A.Add(aluno);
            }

            Console.WriteLine("Quantidade de Alunos curso B:");
            int n2 = int.Parse(Console.ReadLine());
            for(int j = 0; j < n2; j++)
            {
                Console.WriteLine("Digite o código do Aluno: ");
                int aluno = int.Parse(Console.ReadLine());
                B.Add(aluno);
            }
            Console.WriteLine("Quantidade de Alunos curso C:");
            int n3 = int.Parse(Console.ReadLine());
            for (int l = 0; l < n3; l++)
            {
                Console.WriteLine("Digite o código do Aluno: ");
                int aluno = int.Parse(Console.ReadLine());
                C.Add(aluno);
            }

            contagem.UnionWith(A);
            contagem.UnionWith(B);
            contagem.UnionWith(C);
            Console.WriteLine("Total de alunos: " + contagem.Count);
            Console.ReadLine();

            /* foreach(int num in A)
             {
                 Console.WriteLine(num);
             }
             Console.WriteLine("-------------");
             foreach(int num2 in B)
             {
                 Console.WriteLine(num2);
             }

             Console.WriteLine("Digite um valor inteiro: ");
             int x = int.Parse(Console.ReadLine());

             if (A.Contains(x))
             {
                 Console.WriteLine("Pertence ao conjunto A");
             }else if (B.Contains(x))
             {
                 Console.WriteLine("Pertence ao conjunto B");
             }
             else
             {
                 Console.WriteLine("Numero invalido");
             }
             A.IntersectWith(B);
             foreach(int n4 in A)
             {
                 Console.WriteLine(n4);
             }
             B.Remove(1);
             Console.WriteLine("-------------");
             foreach (int n1 in B)
             {
                 Console.WriteLine(n1);
             }
             Console.WriteLine("----------------");
             A.ExceptWith(B);
             foreach(int n2 in A)
             {
                 Console.WriteLine(n2);
             }
             Console.WriteLine("-----------------");
             A.UnionWith(B);
             foreach(int n3 in A)
             {
                 Console.WriteLine(n3);
             }*/
        }
    }
}
