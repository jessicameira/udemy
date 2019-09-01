using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace udemy_secao4_aula42
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Qtde { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome_const, double preco_const, int qtde_const)
        {
            _nome = nome_const;
            Preco = preco_const;
            Qtde = qtde_const;
        }

        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
      
        public double ValorTotalEmEstoque()
        {
            return Qtde * Preco;
        }

        public void adicionarProdutos(int quantidade)
        {
            Qtde = Qtde + quantidade;
        }
        public override string ToString()
        {
            return _nome + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Qtde
                + " peças em estoque"
                + " Saldo em estoque: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void removerProdutos(int quantidade)
        {
            Qtde = Qtde - quantidade;
        }

       
    }
}
