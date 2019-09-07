using System;
using System.Globalization;

namespace udemy_secao6_aulaVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Quantos valores serão digitados? ");
            int qtde = int.Parse(Console.ReadLine());
            double [] vetor = new double [qtde];

            for(int i = 0; i < qtde; i++)
            {
                Console.Write("Valor: ");
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine(vetor[i]);
            }

            double sum = 0;

            for(int i = 0; i < qtde; i++)
            {
                sum += vetor[i];
            }

            double media = sum / qtde;

            Console.WriteLine(media);
        }
    }
}
