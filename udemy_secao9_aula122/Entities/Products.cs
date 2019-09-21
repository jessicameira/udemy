using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_secao9_aula122.Entities
{
    class Products
    {
        public string NameProduto { get; set; }
        public double PriceProduto { get; set; }

        public Products()
        {
        }

        public Products(string nameProduto, double priceProduto)
        {
            NameProduto = nameProduto;
            PriceProduto = priceProduto;
        }

        public override string ToString()
        {
            return NameProduto;
        }
    }
}
