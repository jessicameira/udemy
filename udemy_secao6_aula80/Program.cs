using System;

namespace udemy_secao6_aula80
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int negativos = 0;
            int[,] mat = new int[n, n];
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Digite os números da linha:");
                string[] valores = Console.ReadLine().Split(' ');
                for(int j = 0; j<n; j++)
                {
                    mat[i, j] =int.Parse( valores[j]);
                }
            }
            Console.WriteLine("Diagonal: ");
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(mat[k,k]);
            }
            for(int l = 0; l < n; l++)
            {
                for (int m = 0; m <n; m++)
                {
                    if (mat[l,m] < 0)
                    {
                        negativos++;
                    }
                }
            }
            Console.WriteLine(negativos);
        }
    }
}
