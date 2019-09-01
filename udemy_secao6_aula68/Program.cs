using System;

namespace udemy_secao6_aula68
{
    class Program
    {
        static void Main(string[] args)
        {
            //duas maneiras de setar um Nullable
            Nullable<double> x = null;

            double? y = 10;
            //pegue o valor que está atruibuido a variavel
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //informe se tem valor falso ou verdadeiro
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //operador de coalescencia, caso o x seja nulo será salvo o numero que está a direita do operador.
            double? z = x ?? 15.00;

            Console.WriteLine(z);
        }
    }
}
