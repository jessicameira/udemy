using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace udemy_secao6_aulaVetores2
{
    class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos()
        {
        }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return "Produto: " + Nome + ", Valor $" + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
